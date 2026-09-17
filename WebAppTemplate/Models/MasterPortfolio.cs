namespace WebAppTemplate.Models
{
    public class MasterPortfolio : BaseEntity
    {
        // CategoryId / firstImage / secondImage / title / icon 

        public int CategoryId { get; set; } 
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Icon { get; set; }
        public MasterCategory Category { get; set; }
    }
}
