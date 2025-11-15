using System.Collections.Generic;
using System.Data.Entity;

namespace Portfolio.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("PortfolioConnection") 
        { 
        }

        public DbSet<StudentProfile> StudentProfile { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<SocialLink> SocialLink { get; set; }
    }
}