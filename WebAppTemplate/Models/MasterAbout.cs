namespace WebAppTemplate.Models
{
    public class MasterAbout : BaseEntity
    {
        // Name / ImageUrl / CV_URL / Desc / DoB / Country / Address / Email

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string CV_URL { get; set; }
        public string Desc { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
