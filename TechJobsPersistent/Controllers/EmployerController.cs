﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;
        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        /*   private EmployerDbContext context;
           public EmployerController(EmployerDbContext dbContext)
           {
               context = dbContext;
           }*/
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }
        /*[HttpGet("/Employer/Add")]*/
        public IActionResult Add()
        {
            List<Employer> employers = context.Employers.ToList();
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();
            return View(addEmployerViewModel);
        }
        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if( ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };
                context.Employers.Add(newEmployer);
                context.SaveChanges();
                return Redirect("/Employer/index");
            }
           return View("/Employer/Add");
        }
        [HttpGet]
        public IActionResult About()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);



            /*'TechJobsPersistent.ViewModels.AddEmployerViewModel'*/
           
            
        }
    }
}
