using FluentValidation;
using Infrastructure.Queries;
using OrderingService.Dal;
using OrderingService.Dal.Abstractions;

namespace OrderingService.Domain
{
    public class GetQuery
    {
        public class Query : IQuery<Result>
        {
            public Guid Id { get; set; }

            public Type ResultEntityType { get; set; } = null!;
        }

        public class Result
        {
            public Model? Entity { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {
                RuleFor(q => q.Id).NotEmpty();
                
                RuleFor(q => q.ResultEntityType)
                    .Must(t => t.IsSubclassOf(typeof(Model)))
                    .WithMessage("Тип получаемой сущности должнен быть доменной моделью.")
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
                var entity = await _db.FindAsync(query.ResultEntityType, query.Id);

                return new Result
                {
                    Entity = entity as Model,
                };
            }
        }
    }
}
