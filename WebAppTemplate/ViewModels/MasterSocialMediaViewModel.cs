using System.ComponentModel;

namespace WebAppTemplate.ViewModels
{
    public class MasterSocialMediaViewModel
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        [DisplayName("Is Active ?")]
        public bool isActive { get; set; }
        [DisplayName("Is Social Media ?")]

        public bool isSocialMedia { get; set; }
        public string Keyword { get; set; }
        public string Title { get; set; }



    }
}
