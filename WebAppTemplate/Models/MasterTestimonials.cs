namespace WebAppTemplate.Models
{
    public class MasterTestimonials : BaseEntity
    {
        // image / Desc / title / icon
        public string ImageUrl { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Keyword { get; set; }

    }
}
