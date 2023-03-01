using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class ProductTypeRefConfiguration : IEntityTypeConfiguration<ProductTypeRef>
    {
        public void Configure(EntityTypeBuilder<ProductTypeRef> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasAlternateKey(t => t.Name);

            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.Name)
                .IsRequired();

            builder.HasData(Enum.GetValues<ProductType>().Cast<ProductType>().Select(type => new ProductTypeRef(type)));
        }
    }
}
