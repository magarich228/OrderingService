using FluentValidation;
using Infrastructure.Commands;
using OrderingService.Dal;
using OrderingService.Dal.Abstractions;

namespace OrderingService.Domain
{
    public class DeleteCommand
    {
        public class Command : ICommand<Result>
        {
            public Guid Id { get; set; }

            public Type Type { get; set; } = null!;
        }

        public class Result
        {
            public bool Success { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator(OrderingContext db)
            {
                RuleFor(c => c.Id)
                    .NotEmpty();

                RuleFor(c => c.Type)
                    .Must(t => t.IsSubclassOf(typeof(Model)))
                    .WithMessage("Тип удаляемой сущности должнен быть доменной моделью.")
                    .NotEmpty();

                RuleFor(c => c)
                     .Must(c => db.Find(c.Type, c.Id) != null).WithMessage("Сущности с таким Id не существует.");
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
                var result = await Delete(command.Id, command.Type, cancellationToken);

                return result;
            }

            public async Task<Result> Delete(Guid id, Type type, CancellationToken cancellationToken)
            {
                var entity = await _db.FindAsync(type, id, cancellationToken);

                if (entity == null)
                {
                    return new Result
                    {
                        Success = false
                    };
                }

                _db.Remove(entity!);

                return new Result
                {
                    Success = await _db.SaveChangesAsync(cancellationToken) > 0
                };
            }
        }
    }
}
