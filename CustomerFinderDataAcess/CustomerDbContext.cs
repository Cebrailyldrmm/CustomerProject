using CustomerEntity;
using Microsoft.EntityFrameworkCore;

namespace CustomerFinderDataAcess
{
    public class CustomerDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-AENF83D\\SQLEXPRESS; Database=CustomerDb;uid=cebrail;pwd=1234;TrustServerCertificate=True");
        }
        public DbSet<Customer> customers { get; set; }
    }
}