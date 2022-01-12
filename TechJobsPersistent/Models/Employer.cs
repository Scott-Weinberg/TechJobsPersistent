using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace TechJobsPersistent.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
     /*   public List<SelectListItem> Allemployers { get; set; }*/
        public Employer()
        {
        }

        public Employer(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id &&
                   Name == employer.Name &&
                   Location == employer.Location;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Location);
        }
    }
}
