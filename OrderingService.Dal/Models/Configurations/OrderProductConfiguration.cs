using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        private readonly IEnumerable<OrderProduct> _productsInOrders;

        public OrderProductConfiguration(IEnumerable<OrderProduct> productsInOrders)
        {
            _productsInOrders = productsInOrders;
        }

        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(op => op.Id);

            builder.Property(op => op.Id)
                .IsRequired();

            builder.Property(op => op.ProductId)
                .IsRequired();

            builder.Property(op => op.OrderId)
                .IsRequired();

            builder.ToTable(o => o.HasCheckConstraint("Price", "Price > 0"));
            builder.Property(o => o.Price)
                .IsRequired();

            builder.ToTable(o => o.HasCheckConstraint("Quantity", "Quantity >= 0"));
            builder.Property(o => o.Quantity)
                .IsRequired();

            builder.HasData(_productsInOrders);
        }
    }
}
