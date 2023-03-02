using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        private readonly IEnumerable<Client> _clients;

        public ClientConfiguration(IEnumerable<Client> clients)
        {
            _clients = clients;
        }

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired();

            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasAlternateKey(c => c.Phone);
            builder.Property(c => c.Phone)
                .IsRequired();

            builder.HasData(_clients);
        }
    }
}
