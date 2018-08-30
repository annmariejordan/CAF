using ChoresAndFulfillment.Models;
using ChoresAndFulfillment.Web.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoresAndFulfillment.Web.Services.Interfaces
{
    public interface IListAllJobsService:
        IUserAndContextRepository
    {
        bool AnyActiveJobs();
        List<ActiveJobViewModel> ViewAllActiveJobs();
        bool WorkerAlreadyApplied(int jobId);
    }
}
