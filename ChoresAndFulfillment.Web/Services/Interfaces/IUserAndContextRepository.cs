using ChoresAndFulfillment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoresAndFulfillment.Web.Services.Interfaces
{
    public interface IUserAndContextRepository
    {
        User GetCurrentUser();
        void AddJob(Job job);
        bool IsAuthenticated();
        bool IsEmployer();
        bool IsWorker();
    }
}
