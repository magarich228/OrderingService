using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired();

            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Phone)
                .IsRequired();
        }
    }
}
