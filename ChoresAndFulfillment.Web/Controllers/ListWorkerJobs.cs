using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoresAndFulfillment.Data;
using ChoresAndFulfillment.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ChoresAndFulfillment.Models;
using ChoresAndFulfillment.Web.Services.Interfaces;

namespace ChoresAndFulfillment.Controllers
{
    public class ListWorkerJobsController : Controller
    {
        private IListWorkerJobsService service;

        public ListWorkerJobsController(IListWorkerJobsService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            if (!service.IsWorker())
            {
                return Redirect("/");
            }
            User user = service.GetCurrentUser();
            WorkerAccount workerAccount = service.GetWorkerAccount();
            if (!service.HasActiveJobs())
            {
                ViewData["Jobs"] = "<h2>You have no active jobs!</h2>";
                return View();
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var job in service.ActiveJobs())
            {
                stringBuilder.AppendLine("<li>");
                stringBuilder.AppendLine("<a href=\"/WorkerActiveJob/Index/" + job.Id + "\">" + job.Name + "</a>");
                stringBuilder.AppendLine("</li>");
            }
            ViewData["Jobs"] = stringBuilder.ToString();

            return View();
        }
    }
}