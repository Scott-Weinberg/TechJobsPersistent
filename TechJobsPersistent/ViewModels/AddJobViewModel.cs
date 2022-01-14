using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
       
        public Employer Employer { get; set; }
        [Required]
         public int EmployerId { get; set; }
      
       [Required]
        public string JobName { get; set; }
        public List<Skill> SkillList { get; set; }
    
        /*public List<int> SkillIds { get; set; }*/

        public List<SelectListItem> AllEmployers { get; set; }

        /*public AddJobViewModel(List<Skill> skillList)
        {
            skillList = new List<Skill>();
            foreach(var skill in skillList)
            {
                Name = skill.Name;
                Description = skill.Description;
             }
        
        }*/

        public AddJobViewModel( List<Employer> employers, List<Skill> skillList)
        {

              SkillList= skillList;
             AllEmployers  = new List<SelectListItem>();

            foreach (var employee in employers)
            {
                AllEmployers.Add(new SelectListItem
                {
                    Value = employee.Id.ToString(),
                    Text = employee.Name
                });
            }

          }

        public AddJobViewModel()
        {
        }
    }
}
