using System.ComponentModel;

namespace WebAppTemplate.ViewModels
{
    public class MasterTestimonialsViewModel
    {

        [DisplayName("Image")]
        public string ImageUrl { get; set; }
        public string Desc { get; set; }
        public string Keyword { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Id { get; set; }

        [DisplayName("Active")]

        public bool isActive { get; set; }
        public IFormFile? imageFile { get; set; }

    }
}
