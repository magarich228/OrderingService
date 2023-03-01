using Microsoft.EntityFrameworkCore;
using OrderingService.Dal.Models;
using OrderingService.Dal.Models.Configurations;

namespace OrderingService.Dal
{
    public class OrderingContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> ProductsInOrder { get; set; }

        public OrderingContext(DbContextOptions<OrderingContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
