using FluentValidation;
using Infrastructure.Commands;
using Microsoft.EntityFrameworkCore;
using OrderingService.Dal;
using OrderingService.Dal.Models;

namespace OrderingService.Domain.Orders
{
    public class CreateOrderCommand
    {
        public class Command : ICommand<Result>
        {
            public List<Guid> ProductsInOrderIds { get; set; } = new List<Guid>();

            public List<int> OrderProductsQuantities { get; set; } = new List<int>();

            public Guid ClientId { get; set; }
        }

        public class Result
        {
            public Guid OrderId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator(OrderingContext db)
            {
                RuleFor(c => c.ProductsInOrderIds)
                    .NotNull()
                    .NotEmpty();

                RuleFor(c => c.OrderProductsQuantities)
                    .NotNull()
                    .NotEmpty();

                RuleFor(c => c.ClientId)
                    .NotEmpty()
                    .Must(c => db.Clients.Any(client => client.Id == c))
                    .WithMessage(c => $"Клиента с Id:{c.ClientId} не существует.");

                RuleForEach(c => c.ProductsInOrderIds)
                    .NotEmpty()
                    .Must(c => db.Products.Any(product => product.Id == c))
                    .WithMessage((c, id) => $"Товара с Id:{id} не существует");

                RuleForEach(c => c.OrderProductsQuantities)
                    .NotEmpty()
                    .GreaterThan(0);

                RuleFor(c => c)
                    .Must(c => c.ProductsInOrderIds.Count == c.OrderProductsQuantities.Count);
            }
        }

        public class Handler : ICommandHandler<Command, Result>
        {
            private readonly OrderingContext _db;

            public Handler(OrderingContext db)
            {
                _db = db;
            }

            public async Task<Result> Handle(Command command, CancellationToken cancellationToken)
            {
                var result = await CreateOrder(
                    command.ProductsInOrderIds,
                    command.OrderProductsQuantities,
                    command.ClientId,
                    cancellationToken);

                return result;
            }

            private async Task<Result> CreateOrder(
                List<Guid> productsInOrderIds,
                List<int> orderProductsQuantities,
                Guid clientId,
                CancellationToken cancellationToken)
            {
                var order = new Order()
                {
                    Id = Guid.NewGuid(),
                    ClientId = clientId,
                    CreatedAt = DateTime.UtcNow,
                };

                var productsInOrder = new List<OrderProduct>();

                for (int i = 0; i < productsInOrderIds.Count; i++)
                {
                    var productPrice = await _db.Products.Select(p => new { p.Id, p.Price })
                        .FirstAsync(p => p.Id == productsInOrderIds[i]);

                    productsInOrder.Add(new OrderProduct()
                    {
                        Id = Guid.NewGuid(),
                        OrderId = order.Id,
                        ProductId = productsInOrderIds[i],
                        Quantity = orderProductsQuantities[i],
                        Price = productPrice.Price
                    });
                }

                await _db.Orders.AddAsync(order);
                await _db.ProductsInOrders.AddRangeAsync(productsInOrder);

                for (int i = 0; i < productsInOrder.Count; i++)
                {
                    Product product = await _db.Products.FirstAsync(p => p.Id == productsInOrderIds[i]);

                    product.Quantity -= orderProductsQuantities[i];
                }

                await _db.SaveChangesAsync(cancellationToken);

                return new Result()
                {
                    OrderId = order.Id
                };
            }
        }
    }
}
