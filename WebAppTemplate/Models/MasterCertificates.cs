namespace WebAppTemplate.Models
{
    public class MasterCertificates:BaseEntity
    {
        // image / certName/ memberId / date

        public string ImageURL { get; set; }
        public string CertificationName { get; set; }
        public int MemberId { get; set; }
        public string Keyword { get; set; }
        public DateTime Date { get; set; }


    }
}
