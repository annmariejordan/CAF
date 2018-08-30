using ChoresAndFulfillment.Data;
using ChoresAndFulfillment.Models;
using ChoresAndFulfillment.Web.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ChoresAndFulfillment.Web.Services
{
    public class UserAndContextRepository : IUserAndContextRepository
    {
        protected CAFContext applicationDbContext;
        protected UserManager<User> userManager;
        protected IHttpContextAccessor httpContextAccessor;
        public UserAndContextRepository(CAFContext applicationDbContext, 
            UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            this.applicationDbContext = applicationDbContext;
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        public void AddJob(Job job)
        {
            this.applicationDbContext.Jobs.Add(job);
            this.applicationDbContext.SaveChanges();
        }

        public User GetCurrentUser()
        {
            return userManager.GetUserAsync(this.httpContextAccessor.HttpContext.User).Result;
        }
        public bool IsAuthenticated()
        {
            if (this.httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmployer()
        {
            if (!IsAuthenticated())
            {
                return false;
            }
            var currentUser = GetCurrentUser();
            if (currentUser.AccountType == "EmployerAccount")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsWorker()
        {
            if (!IsAuthenticated())
            {
                return false;
            }
            var currentUser = GetCurrentUser();
            if (currentUser.AccountType == "WorkerAccount")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
