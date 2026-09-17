namespace WebAppTemplate.ViewModels
{
    public class MasterSkillsViewModel
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public string SkillName { get; set; }
        public int Percentage { get; set; }
        public bool isCoding { get; set; }
        public bool isDesign { get; set; }
        public bool isKnowledges { get; set; }
        public int orderNumber { get; set; }
    }
}
