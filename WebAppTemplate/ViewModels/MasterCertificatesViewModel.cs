namespace WebAppTemplate.ViewModels
{
    public class MasterCertificatesViewModel
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public string ImageURL { get; set; }
        public IFormFile ImageFile { get; set; }
        public string CertificationName { get; set; }
        public int MemberId { get; set; }
        public string Keyword { get; set; }
        public DateTime Date { get; set; }
    }
}
