using OrderingService.Dal.Abstractions;

namespace OrderingService.Dal.Models
{
    public class ClientCredentials : Model
    {
        public Guid ClientId { get; set; }

        public Client? Client { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
