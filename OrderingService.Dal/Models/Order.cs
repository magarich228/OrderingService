namespace OrderingService.Dal.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Client? Client { get; set; }
    }
}
