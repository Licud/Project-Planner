using System.Data.Entity;
using Data_Access_Layer.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data_Access_Layer
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ProjectPlannerDatabase", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Bug> Bug { get; set; }

        public DbSet<Features> Features { get; set; }

        public DbSet<Objective> Objective { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<Task> Task { get; set; }

        public DbSet<Technology> Technology { get; set; }

        public DbSet<TimeLog> TimeLog { get; set; }
    }
}
