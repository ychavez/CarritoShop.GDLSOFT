using CarritoShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarritoShop.Infraestructure.Persistence
{
    public class CarritoDbContext : DbContext
    {
        public CarritoDbContext(DbContextOptions<CarritoDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Product { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }


    }
}
