using OrderingService.Dal.Abstractions;

namespace OrderingService.Dal.Models
{
    public class Order : Model
    {
        public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Client? Client { get; set; }
    }
}
