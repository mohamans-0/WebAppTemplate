using System.ComponentModel.DataAnnotations;

namespace WebAppTemplate.Models
{
    public class MasterCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Keywrod { get; set; }

    }
}
