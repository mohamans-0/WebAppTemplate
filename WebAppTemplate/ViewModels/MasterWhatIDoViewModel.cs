using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.ViewModels
{
    public class MasterWhatIDoViewModel
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}