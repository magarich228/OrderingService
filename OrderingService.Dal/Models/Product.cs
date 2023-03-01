namespace OrderingService.Dal.Models
{
    public class Product
    {

        public Guid Id { get; set; }

        public ProductType Type { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
