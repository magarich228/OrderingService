﻿namespace OrderingService.Dal.Models
{
    public class OrderProduct
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Product? Product { get; set; }

        public Order? Order { get; set; }
    }
}
