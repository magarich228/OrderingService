using FluentValidation;
using Infrastructure.Queries;
using Microsoft.EntityFrameworkCore;
using OrderingService.Dal;
using OrderingService.Dal.Models;

namespace OrderingService.Domain.Clients
{
    public class GetClientsQuery
    {
        public class Query : IQuery<Result>
        {

        }

        public class Result
        {
            public List<Client> Clients { get; set; } = new List<Client>();
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {

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
                var clients = await GetClients();

                return clients;
            }

            private async Task<Result> GetClients()
            {
                var query = _db.Clients.Select(c => new Client()
                {
                    Id = c.Id,
                    FullName = c.FullName,
                    Phone = c.Phone
                });

                var result = new Result
                {
                    Clients = await query.ToListAsync()
                };

                return result;
            }
        }
    }
}
