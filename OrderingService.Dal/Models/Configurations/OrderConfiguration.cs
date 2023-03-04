using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        private readonly IEnumerable<Order> _orders;

        public OrderConfiguration(IEnumerable<Order> orders)
        {
            _orders = orders;
        }

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                .IsRequired();

            builder.Property(o => o.ClientId)
                .IsRequired();

            builder.Property(o => o.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow)
                .IsRequired();

            builder.HasData(_orders);
        }
    }
}
