using FluentValidation;
using Infrastructure.Queries;
using OrderingService.Dal;

namespace OrderingService.Domain.Products
{
    public class GetProductQuantityQuery
    {
        public class Query : IQuery<Result>
        {
            public Guid ProductId { get; set; }
        }

        public class Result
        {
            public int? StockQuantity { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator(OrderingContext db)
            {
                RuleFor(x => x.ProductId)
                    .NotEmpty()
                    .Must(q => db.Products.Any(product => product.Id == q))
                    .WithMessage(q => $"Товара с Id:{q.ProductId} не существует.");
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
                var product = await _db.Products.FindAsync(query.ProductId);

                return new Result()
                {
                    StockQuantity = product != null ?
                        product.Quantity :
                        null
                };
            }
        }
    }
}
