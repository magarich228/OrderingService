using FluentValidation;
using Infrastructure.Queries;
using Microsoft.EntityFrameworkCore;
using OrderingService.Dal;
using OrderingService.Dal.Models;

namespace OrderingService.Domain.Orders
{
    public class GetOrdersByClientQuery
    {
        public class Query : IQuery<Result>
        {
            public Guid ClientId { get; set; }
        }

        public class Result
        {
            public List<Order> Orders { get; set; } = new List<Order>();
        }

        public class Vallidator : AbstractValidator<Query>
        {
            public Vallidator(OrderingContext db)
            {
                RuleFor(q => q.ClientId)
                    .NotEmpty()
                    .Must(q => db.Clients.Any(client => client.Id == q))
                    .WithMessage(q => $"Клиента с Id:{q.ClientId} не существует.");
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
                var result = await GetOrdersAsc(
                    query.ClientId,
                    cancellationToken);

                return result;
            }

            private async Task<Result> GetOrdersAsc(
                Guid clientId,
                CancellationToken cancellationToken)
            {
                var query = _db.Orders
                    .Where(o => o.ClientId == clientId)
                    .OrderBy(o => o.CreatedAt);

                var orders = await query.ToListAsync(cancellationToken);

                return new Result()
                {
                    Orders = orders
                };
            }
        }
    }
}
