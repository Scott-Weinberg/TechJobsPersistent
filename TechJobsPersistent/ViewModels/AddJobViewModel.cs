using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
       
        public Employer Employer { get; set; }
         public int EmployerId { get; set; }
        public Job Job { get; set; }
        public int JobId { get; set; }

        public string JobName { get; set; }

        public DbSet<Employer> Employers{ get; set; }
        public List<SelectListItem> AllEmployers { get; set; }
    



        public AddJobViewModel( int employerId, List<Employer> employers)
        {
            List<SelectListItem> AllEmployers  = new List<SelectListItem>();

            foreach (var employee in employers)
            {
                AllEmployers.Add(new SelectListItem
                {
                    Value = employee.Id.ToString(),
                    Text = employee.Name
                });
            }

            EmployerId = employerId;
        }

        public AddJobViewModel()
        {
        }
    }
}
