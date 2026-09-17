namespace WebAppTemplate.ViewModels
{
    public class MasterPortfolioViewModel
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public int CategoryId { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Icon { get; set; }
    }
}
