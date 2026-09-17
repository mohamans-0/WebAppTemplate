using System;

namespace WebAppTemplate.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public string? CreateUser { get; set; }
        public string? EditUser { get; set; }
        public string? DeleteUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
