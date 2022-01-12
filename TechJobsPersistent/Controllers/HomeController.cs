using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;
using TechJobsPersistent.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace TechJobsPersistent.Controllers
{
    public class HomeController : Controller
    {
        private JobDbContext context;

        public HomeController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        
        public IActionResult Index()
        {
            List<Job> jobs = context.Jobs.Include(j => j.Employer).ToList();

            return View(jobs);
        }

       /* public IActionResult Add()
        {
            List<SelectListItem> allEmployers = context.Employers.ToList();
            AddJobViewModel addJobViewModel = new AddJobViewModel();
            return View(addJobViewModel);
        }*/

        [HttpGet("/Add")]
        public IActionResult AddJob(AddJobViewModel addJobViewModel)
        {
            
            Job newJob = new Job
            {
                EmployerId = addJobViewModel.EmployerId,
                Name = addJobViewModel.JobName,

            };
            
            return View(addJobViewModel);

        }
      /*  List<SelectListItem> AddAllEmployers(Employer employer, JobName)
        {
            List<SelectListItem> allEmployers = context.Employers.ToList();

         *//*   Employer.Name = employer.Name;
            Employer.Location = employer.Location;*//*


        }*/

        public IActionResult ProcessAddJobForm(AddJobViewModel addJobViewModel)
        {
           
            if (ModelState.IsValid)
            {
                Job newJob = new Job()
                {
                  Name = addJobViewModel.JobName,
                  EmployerId = addJobViewModel.EmployerId

                };
                context.Jobs.Add(newJob);
                context.SaveChanges();
                return Redirect("/Employer/");
            }
            return View(addJobViewModel);

        }




        public IActionResult Detail(int id)
        {
            Job theJob = context.Jobs
                .Include(j => j.Employer)
                .Single(j => j.Id == id);

            List<JobSkill> jobSkills = context.JobSkills
                .Where(js => js.JobId == id)
                .Include(js => js.Skill)
                .ToList();

            JobDetailViewModel viewModel = new JobDetailViewModel(theJob, jobSkills);
            return View(viewModel);
        }
    }
}
