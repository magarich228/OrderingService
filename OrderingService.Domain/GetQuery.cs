using FluentValidation;
using Infrastructure.Queries;
using OrderingService.Dal;
using OrderingService.Dal.Abstractions;

namespace OrderingService.Domain
{
    public class GetQuery<TModel> where TModel : Model
    {
        public class Query : IQuery<Result>
        {
            public Guid Id { get; set; }
        }

        public class Result
        {
            public TModel? Entity { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {
            public Validator()
            {
                RuleFor(x => x.Id).NotEmpty();
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
                var entity = await _db.FindAsync<TModel>(query.Id);

                return new Result
                {
                    Entity = entity
                };
            }
        }
    }
}
