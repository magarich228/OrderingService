using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrderingService.Dal.Models.Configurations
{
    public class ClientCredentialsConfiguration : IEntityTypeConfiguration<ClientCredentials>
    {
        private readonly IEnumerable<ClientCredentials> _credentials;

        public ClientCredentialsConfiguration(IEnumerable<ClientCredentials> credentials)
        {
            _credentials = credentials;
        }

        public void Configure(EntityTypeBuilder<ClientCredentials> builder)
        {
            builder.HasKey("ClientId", "Login");

            builder.Property(cc => cc.ClientId)
                .IsRequired();

            builder.Property(cc => cc.Login)
                .HasMaxLength(128)
                .IsRequired();

            builder.Property(cc => cc.Password)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasData(_credentials);
        }
    }
}
