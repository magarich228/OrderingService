using FluentValidation;
using Infrastructure.Queries;
using Microsoft.EntityFrameworkCore;
using OrderingService.Dal;
using OrderingService.Dal.Models;

namespace OrderingService.Domain.Clients
{
    public class AuthenticateQuery
    {
        public class Query : IQuery<Result>
        {
            public string Login { get; set; } = default!;

            public string Password { get; set; } = default!;
        }

        public class Result
        {
            public ClientCredentials? ClientWithCredentialsWithoutPassword { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {
                RuleFor(q => q.Login)
                    .MaximumLength(128)
                    .NotEmpty();

                RuleFor(q => q.Password)
                    .MaximumLength(200)
                    .NotEmpty();
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
                var result = await Authenticate(query.Login, query.Password, cancellationToken);

                return result;
            }

            private async Task<Result> Authenticate(
                string login, 
                string password,
                CancellationToken cancellationToken)
            {
                var credentials = await _db.ClientCredentials.SingleOrDefaultAsync(credentials => 
                    credentials.Login == login &&
                    credentials.Password == password);

                if (credentials == null)
                {
                    return new Result();
                }

                var client = await _db.Clients.SingleOrDefaultAsync(client => client.Id == credentials.ClientId, cancellationToken);

                if (client == null)
                {
                    return new Result();
                }

                return new Result
                {
                    ClientWithCredentialsWithoutPassword = new ClientCredentials
                    {
                        Client = client,
                        ClientId = client.Id,
                        Login = credentials.Login
                    }
                };
            }
        }
    }
}
