using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderingService.Dal.Models;
using OrderingService.Dal.Models.Configurations;

namespace OrderingService.Dal
{
    public class OrderingContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderProduct> ProductsInOrders { get; set; } = null!;
        public DbSet<ProductTypeRef> ProductTypes { get; set; } = null!;
        public DbSet<ClientCredentials> ClientCredentials { get; set; } = null!;

        private readonly ILogger<OrderingContext> _logger;
        private readonly SeedData _data;

        public OrderingContext(
            DbContextOptions<OrderingContext> options,
            ILoggerFactory loggerFactory,
            SeedData data)
            : base(options)
        {
            _logger = loggerFactory.CreateLogger<OrderingContext>();
            _data = data;

            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration(_data.Clients));
            _logger.LogInformation($"{Clients.GetType().Name} seeded.");

            modelBuilder.ApplyConfiguration(new OrderConfiguration(_data.Orders));
            _logger.LogInformation($"{Orders.GetType().Name} seeded.");

            modelBuilder.ApplyConfiguration(new ProductConfiguration(_data.Products));
            _logger.LogInformation($"{Products.GetType().Name} seeded.");

            modelBuilder.ApplyConfiguration(new OrderProductConfiguration(_data.ProductsInOrders));
            _logger.LogInformation($"{ProductsInOrders.GetType().Name} seeded.");

            modelBuilder.ApplyConfiguration(new ProductTypeRefConfiguration());
            _logger.LogInformation($"{ProductTypes.GetType().Name} seeded.");

            modelBuilder.ApplyConfiguration(new ClientCredentialsConfiguration(_data.ClientsCredentials));
            _logger.LogInformation($"{ClientCredentials.GetType().Name} seeded.");

            base.OnModelCreating(modelBuilder);
        }
    }
}
