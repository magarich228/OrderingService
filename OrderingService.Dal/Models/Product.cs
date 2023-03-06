using OrderingService.Dal.Abstractions;

namespace OrderingService.Dal.Models
{
    public class Product : Model
    {
        public Guid Id { get; set; }

        public ProductType ProductTypeRefId { get; set; }

        public ProductTypeRef? ProductTypeRef { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
