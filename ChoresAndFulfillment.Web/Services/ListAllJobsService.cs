using ChoresAndFulfillment.Data;
using ChoresAndFulfillment.Models;
using ChoresAndFulfillment.Models.Enums;
using ChoresAndFulfillment.Web.Data.ViewModels;
using ChoresAndFulfillment.Web.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoresAndFulfillment.Web.Services
{
    public class ListAllJobsService : UserAndContextRepository, IListAllJobsService
    {
        public ListAllJobsService
            (CAFContext applicationDbContext, UserManager<User> userManager, 
            IHttpContextAccessor httpContextAccessor) : 
            base(applicationDbContext, userManager, httpContextAccessor)
        {
        }

        public List<ActiveJobViewModel> ViewAllActiveJobs()
        {
            return applicationDbContext.Jobs.Include(job => job.JobCreator).
                    ThenInclude(jobCreator => jobCreator.User).
                    ThenInclude(user => user.RatingsReceived).Where(job => job.JobState == JobState.Hiring).
                    Select(a=>new ActiveJobViewModel()
                    {
                      Id=a.Id,
                      Name=a.Name,
                      Description=a.Description,
                      JobCreatorName=a.JobCreator.User.UserName,
                      JobCreatorRating=a.JobCreator.User.Rating,
                      PayUponCompletion=a.PayUponCompletion
                    }).
                    ToList();
        }

        public bool AnyActiveJobs()
        {
            if (applicationDbContext.Jobs.Any(a => a.JobState == JobState.Hiring))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool WorkerAlreadyApplied(int jobId)
        {
            WorkerAccount workerAccount = applicationDbContext.
                WorkerAccounts.First
                (a=>a.Id==GetCurrentUser().WorkerAccountId);
            Job job = applicationDbContext.Jobs.Where(a => a.Id == jobId).
                Include(a => a.Applicants).First();
            if (workerAccount.ActiveApplications.Any(a => a.JobId == job.Id))
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
