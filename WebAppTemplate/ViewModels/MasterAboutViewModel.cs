using System.ComponentModel;
using WebAppTemplate.Models;

namespace WebAppTemplate.ViewModels
{
    public class MasterAboutViewModel
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        [DisplayName("Image")]
        public string ImageUrl { get; set; }

        [DisplayName("CV")]
        public string CV_URL { get; set; }
        public string Desc { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IFormFile? imageFile { get; set; }
        public IFormFile? cvFile { get; set; }
        public bool isActive { get; set; }

    }
}
