namespace OrderingService.Dal.Models
{
    public class ClientCredentials
    {
        public Guid ClientId { get; set; }

        public Client? Client { get; set; }

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
