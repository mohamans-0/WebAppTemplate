namespace WebAppTemplate.Models
{
    public class MasterEducationAndExperience:BaseEntity
    {
        // year / uniName / major / desc / isEdu

        public int Year { get; set; }
        public string UniName { get; set; }
        public string Major { get; set; }
        public string Keywrod { get; set; }
        public string Desc { get; set; }
        public bool IsEdu { get; set; }
        public bool isActive { get; set; }
    }
}
