using System;
namespace TechJobsPersistent.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Skill()
        {
        }
        public Skill(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Skill(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
