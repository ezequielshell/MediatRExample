using MediatRExample.Domain.Entity; 
using Microsoft.EntityFrameworkCore;

namespace MediatRExample.Domain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
