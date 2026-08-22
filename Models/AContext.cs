using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class AContext : DbContext
    {
        public AContext(DbContextOptions<AContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MVCProject.Models.Application>().HasKey(a => a.ApplicationId);
        }
        public DbSet<MVCProject.Models.Application> Apps { get; set;}
    }
}
