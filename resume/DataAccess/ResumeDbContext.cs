using Microsoft.EntityFrameworkCore;
using resume.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess
{
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext()
        {

        }
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<PersonalInformation> PersonalInformation { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<SocialProfile> SocialProfiles { get; set; }
        public virtual DbSet<Responsibility> Responsibilities { get; set; }
    }
}
