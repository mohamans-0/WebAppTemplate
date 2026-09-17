using System.ComponentModel;

namespace WebAppTemplate.ViewModels
{
    public class MasterCilentsViewModel
    {
        public int Id { get; set; }

        [DisplayName("Active")]

        public bool isActive { get; set; }

        [DisplayName("Image")]
        public string imageURL { get; set; }
        public IFormFile? imageFile { get; set; }
        public string URL { get; set; }
    }
}
