using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
       
       [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Location is required")]
        public string Location { get; set; }

        public AddEmployerViewModel(string  name, string location)
        {
           Name = name;
           Location = location;
        }

        public AddEmployerViewModel()
        {
        }
    }
}
