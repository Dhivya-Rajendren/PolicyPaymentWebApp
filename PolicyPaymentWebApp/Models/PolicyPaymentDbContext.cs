using Microsoft.EntityFrameworkCore;

namespace PolicyPaymentWebApp.Models
{
    public class PolicyPaymentDbContext:DbContext
    {
        public PolicyPaymentDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Policy> Policies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocaldb;Database=PolicyPaymentDB;integrated security=true");

        }

    }
}
