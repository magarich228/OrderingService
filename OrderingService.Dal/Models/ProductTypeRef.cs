namespace OrderingService.Dal.Models
{
    public class ProductTypeRef
    {
        public ProductType Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public ProductTypeRef(
            ProductType id)
        {
            Id = id;
            Name = id.ToString();
            Description = id.GetDescription();
        }
    }
}
