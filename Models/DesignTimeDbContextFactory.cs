using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MVCProject.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AContext>
    {
        public AContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AContext>();

            optionsBuilder.UseSqlite("Server=(localdb)\\mssqllocaldb;Database=MigrationDb;Trusted_Connection=true");

            return new AContext(optionsBuilder.Options);
        }
    }
}
