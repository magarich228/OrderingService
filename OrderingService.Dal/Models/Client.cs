using OrderingService.Dal.Abstractions;

namespace OrderingService.Dal.Models
{
    public class Client : Model
    {
        public Guid Id { get; set; }

        public string FullName { get; set; } = null!;

        public string Phone { get; set; } = null!;
    }
}
