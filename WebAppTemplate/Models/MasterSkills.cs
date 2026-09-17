namespace WebAppTemplate.Models
{
    public class MasterSkills:BaseEntity
    {
        //skillName / percentage / isCoding / isKnowledges / orderNumber'

        public string SkillName { get; set; }
        public int Percentage { get; set; }
        public bool isCoding { get; set; }
        public bool isDesign { get; set; }
        public bool isKnowledges { get; set; }
        public int orderNumber { get; set; }    

    }
}
