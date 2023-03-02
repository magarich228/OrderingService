using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        private readonly IEnumerable<Product> _products;

        public ProductConfiguration(IEnumerable<Product> products)
        {
            _products = products;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.HasAlternateKey(p => p.Name);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(300);

            builder.ToTable(p => p.HasCheckConstraint("Price", "Price > 0"));
            builder.Property(p => p.Price)
                .IsRequired();

            builder.ToTable(p => p.HasCheckConstraint("Quantity", "Quantity >= 0"));
            builder.Property(p => p.Quantity)
                .IsRequired();

            builder.HasOne(p => p.ProductTypeRef)
                .WithMany()
                .HasForeignKey(p => p.ProductTypeRefId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasData(_products);
        }
    }
}
