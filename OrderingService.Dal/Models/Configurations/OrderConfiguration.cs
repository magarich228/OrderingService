using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                .IsRequired();

            builder.Property(o => o.ClientId)
                .IsRequired();

            builder.Property(o => o.CreatedAt)
                .IsRequired();
        }
    }
}
