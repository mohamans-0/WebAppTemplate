using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebAppTemplate.Models;
using WebAppTemplate.ViewModels;

namespace WebAppTemplate.Data
{
    public class DataDbContext : IdentityDbContext
    {
        // MasterUser : User Id / Name / Email / Username / Password ...etc
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public DbSet<MasterAbout> MasterAbouts { get; set; }
        public DbSet<MasterPositions> MasterPositions { get; set; }
        public DbSet<MasterSocialMedia> MasterSocialMedia { get; set; }
        public DbSet<MasterTitles> MasterTitles { get; set; }
        public DbSet<MasterTestimonials> MasterTestimonials { get; set; }
        public DbSet<MasterCilents> MasterCilents { get; set; }
        public DbSet<MasterWhatIDo> MasterWhatIDo { get; set; } 
        public DbSet<MasterFunFacts> MasterFunFacts { get; set; }
        public DbSet<MasterEducationAndExperience> MasterEducationAndExperience { get; set; } 
        public DbSet<MasterSkills> MasterSkills { get; set; }
        public DbSet<MasterCertificates> MasterCertificates { get; set; } 
        public DbSet<MasterCategory> MasterCategory { get; set; }
        public DbSet<MasterPortfolio> MasterPortfolio { get; set; }

    }
}
