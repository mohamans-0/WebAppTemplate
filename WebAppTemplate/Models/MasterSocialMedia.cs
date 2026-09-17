namespace WebAppTemplate.Models
{
    public class MasterSocialMedia : BaseEntity
    {
        //  Icon / Url

        public string Icon { get; set; }
        public string Url { get; set; }
        public bool isActive { get; set; }
        public bool isSocialMedia { get; set; }
        public string Keyword { get; set; }
        public string Title { get; set; }

    }
}
