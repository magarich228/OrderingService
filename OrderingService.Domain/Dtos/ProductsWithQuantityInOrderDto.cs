using OrderingService.Dal.Models;

namespace OrderingService.Domain.Dtos
{
    public class ProductsWithQuantityInOrderDto
    {
        public Product Product { get; set; } = null!;

        public int QuantityInOrder { get; set; }
    }
}
