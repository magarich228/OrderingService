using FluentValidation;
using Infrastructure.Queries;
using Microsoft.EntityFrameworkCore;
using OrderingService.Dal;
using OrderingService.Domain.Dtos;

namespace OrderingService.Domain.Products
{
    public class GetOrderProductsQuery
    {
        public class Query : IQuery<Result>
        {
            public Guid OrderId { get; set; }
        }

        public class Result
        {
            public List<ProductsWithQuantityInOrderDto> ProductsInOrder { get; set; } =
                new List<ProductsWithQuantityInOrderDto>();
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator(OrderingContext db)
            {
                RuleFor(q => q.OrderId)
                    .NotEmpty()
                    .Must(orderId => db.Orders.Any(o => o.Id == orderId))
                    .WithMessage(q => $"Заказа с Id:{q.OrderId} не существует.");
            }
        }

        public class Handler : IQueryHandler<Query, Result>
        {
            private readonly OrderingContext _db;

            public Handler(OrderingContext db)
            {
                _db = db;
            }

            public async Task<Result> Handle(Query query, CancellationToken cancellationToken)
            {
                var result = await GetProducts(query.OrderId, cancellationToken);

                return result;
            }

            private async Task<Result> GetProducts(Guid orderId, CancellationToken cancellationToken)
            {
                var productsInOrderQuery = _db.ProductsInOrders.Where(p => p.OrderId == orderId);
                var productsInOrder = await productsInOrderQuery.ToListAsync(cancellationToken);

                var products = _db.Products.AsEnumerable().Where(p => productsInOrder.Any(po => po.ProductId == p.Id));

                var result = products.Join(
                    productsInOrder,
                    p => p.Id,
                    op => op.ProductId,
                    (p, op) => new ProductsWithQuantityInOrderDto()
                    {
                        Product = p,
                        QuantityInOrder = op.Quantity
                    });

                return new Result()
                {
                    ProductsInOrder = result.ToList()
                };
            }
        }
    }
}
