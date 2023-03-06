using FluentValidation;
using Infrastructure.Commands;
using OrderingService.Dal;
using OrderingService.Dal.Models;
using System.Text.RegularExpressions;

namespace OrderingService.Domain.Clients
{
    public class RegisterClientCommand
    {
        public class Command : ICommand<Result>
        {
            public string Login { get; set; } = null!;

            public string Password { get; set; } = null!;

            public string FullName { get; set; } = null!;

            public string Phone { get; set; } = null!;
        }

        public class Result
        {
            public Guid Id { get; set; }

            public string Login { get; set; } = null!;
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator(OrderingContext db)
            {
                RuleFor(c => c.Login)
                    .MaximumLength(128)
                    .NotEmpty()
                    .Must(u => !db.ClientCredentials.Any(cc => cc.Login == u))
                    .WithMessage("Такое имя пользователя уже зарегестрировано");

                RuleFor(c => c.Password)
                    .MaximumLength(200)
                    .NotEmpty();

                RuleFor(c => c.FullName)
                    .MaximumLength(200)
                    .NotEmpty();

                RuleFor(c => c.Phone)
                    .NotNull().WithMessage("Номер телефона обязателен")
                    .MinimumLength(10)
                    .MaximumLength(20)
                    .Matches(new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
                    .WithMessage("Неправильный формат номер телефона.")
                    .Must(p => !db.Clients.Any(c => c.Phone == p))
                    .WithMessage("Номер телефона уже зарегестрирован");
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
                var result = await AddClient(command, cancellationToken);

                return result;
            }

            private async Task<Result> AddClient(Command command, CancellationToken cancellationToken)
            {
                Client client = new()
                {
                    Id = Guid.NewGuid(),
                    FullName = command.FullName,
                    Phone = command.Phone
                };

                ClientCredentials credentials = new()
                {
                    ClientId = client.Id,
                    Login = command.Login,
                    Password = command.Password
                };

                await _db.Clients.AddAsync(client);
                await _db.ClientCredentials.AddAsync(credentials);

                await _db.SaveChangesAsync();

                return new Result
                {
                    Id = client.Id,
                    Login = credentials.Login
                };
            }
        }
    }
}
