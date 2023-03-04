using FluentValidation;
using Infrastructure.Queries;
using Microsoft.EntityFrameworkCore;
using OrderingService.Dal;
using OrderingService.Dal.Models;

namespace OrderingService.Domain.Products
{
    public class GetProductsQuery
    {
        public class Query : IQuery<Result>
        {
            public ProductType? TypeFilter { get; set; }

            public int? MinimumQuantityFilter { get; set; }

            public bool? SortingByPrice { get; set; }
        }

        public class Result
        {
            public List<Product> Products { get; set; } = new List<Product>();
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {
                RuleFor(query => query.MinimumQuantityFilter).GreaterThanOrEqualTo(0);
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
                var products = await GetProducts(
                    query.TypeFilter,
                    query.MinimumQuantityFilter,
                    query.SortingByPrice);

                return products;
            }

            private async Task<Result> GetProducts(
                ProductType? typeFilter,
                int? minQuantityFilter,
                bool? sortingByPrice)
            {
                var query = _db.Products.AsQueryable();

                if (typeFilter != null)
                {
                    query = query.Where(p => p.ProductTypeRefId == typeFilter);
                }

                if (minQuantityFilter != null)
                {
                    query = query.Where(p => p.Quantity >= minQuantityFilter);
                }

                if (sortingByPrice != null && sortingByPrice.Value)
                {
                    query = query.OrderBy(p => p.Price);
                }

                var result = await query.ToListAsync();

                return new Result()
                {
                    Products = result
                };
            }
        }
    }
}
