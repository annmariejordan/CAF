using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoresAndFulfillment.Data;
using ChoresAndFulfillment.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ChoresAndFulfillment.Models;
using ChoresAndFulfillment.Web.Services.Interfaces;

namespace ChoresAndFulfillment.Controllers
{
    public class ListAllJobsController : Controller
    {
        private IListAllJobsService service;

        public ListAllJobsController(IListAllJobsService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            ViewData["Jobs"] = this.ToPrintOut();
            return this.View();
        }
        public string ToPrintOut()
        {
            if (!service.AnyActiveJobs())
            {
                return "<h1 style=\"text-align:center;\">No jobs found!</h1>";
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<table class=\"table\"\">");
            stringBuilder.AppendLine("<thead>");
            stringBuilder.AppendLine("<tr>");
            stringBuilder.AppendLine("<th scope=\"col\">Job Name</th>");
            stringBuilder.AppendLine("<th scope=\"col\">Description</th>");
            stringBuilder.AppendLine("<th scope=\"col\">Job Creator</th>");
            stringBuilder.AppendLine("<th scope=\"col\">Employer Rating</th>");
            stringBuilder.AppendLine("<th scope=\"col\">Payment</th>");
            if (!service.IsEmployer())
            {
                stringBuilder.AppendLine("<th scope=\"col\">Apply for Job</th>");
            }
            stringBuilder.AppendLine("</tr>");
            stringBuilder.AppendLine("</thead>");
            stringBuilder.AppendLine("<tbody>");

            foreach (var job in service.ViewAllActiveJobs())
            {
                stringBuilder.AppendLine("<tr>");
                stringBuilder.AppendLine("<td>" + job.Name + "</td>");
                stringBuilder.AppendLine("<td>" + job.Description + "</td>");
                stringBuilder.AppendLine("<td>" + job.JobCreatorName + "</td>");
                if (job.JobCreatorRating!=null)
                {
                    stringBuilder.AppendLine("<td>" + job.JobCreatorRating + "</td>");
                }
                else
                {
                    stringBuilder.AppendLine("<td>N/A</td>");
                }
                stringBuilder.AppendLine("<td>" + job.PayUponCompletion + "</td>");

                if (!service.IsEmployer())
                {
                    if (service.IsWorker())
                    {
                        if (service.WorkerAlreadyApplied(job.Id))
                        {
                            stringBuilder.AppendLine($"<td>Already applied.</td>");
                        }
                        else
                        {
                            stringBuilder.AppendLine($"<td><a href=\"/ApplyForJob/Apply/{job.Id}\">Apply For Job</a></td>");
                        }
                    }
                    else
                    {
                        stringBuilder.AppendLine($"<td><a href=\"/ApplyForJob/Apply/{job.Id}\">Apply For Job</a></td>");
                    }
                }
                stringBuilder.AppendLine("</tr>");
            }
            stringBuilder.AppendLine("</tbody>");
            stringBuilder.AppendLine("</table>");
            return stringBuilder.ToString();
        }
    }
}