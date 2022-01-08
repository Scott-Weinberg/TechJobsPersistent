using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public int EmployerId { get; set; }
        public string JobName { get; set; }
        public List<SelectListItem> AllEmployers { get; set; }

        public AddJobViewModel(int employerId, string jobName, List<SelectListItem> allEmployers)
        {
            EmployerId = employerId;
            JobName = jobName;
            AllEmployers = new List<SelectListItem>();
        }

        public AddJobViewModel()
        {
        }
    }
}
