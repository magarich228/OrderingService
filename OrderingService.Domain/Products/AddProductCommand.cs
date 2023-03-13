using FluentValidation;
using Infrastructure.Commands;
using OrderingService.Dal;
using OrderingService.Dal.Models;

namespace OrderingService.Domain.Products
{
    public class AddProductCommand
    {
        public class Command : ICommand<Result>
        {
            public string Name { get; set; } = null!;

            public ProductType ProdcutType { get; set; }

            public decimal Price { get; set; }

            public int Quantity { get; set; } = 0!;
        }

        public class Result
        {
            public Guid? ProductId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator(OrderingContext db)
            {
                RuleFor(c => c.Name)
                    .Must(n => !db.Products.Any(p => p.Name == n)).WithMessage("Товар с таким названием уже существует.")
                    .MaximumLength(300)
                    .NotEmpty();

                RuleFor(c => c.Price)
                    .GreaterThan(0).WithMessage("Цена товара должна быть больше нуля.")
                    .NotEmpty();

                RuleFor(c => c.Quantity)
                    .GreaterThanOrEqualTo(0).WithMessage("Количество товара должно быть больше или равно нулю.")
                    .NotEmpty();
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
                var result = await AddProduct(command, cancellationToken);

                return result;
            }

            public async Task<Result> AddProduct(Command command, CancellationToken cancellationToken)
            {
                Product newProduct = new()
                {
                    Id = Guid.NewGuid(),
                    Name = command.Name,
                    Price = command.Price,
                    Quantity = command.Quantity,
                    ProductTypeRefId = command.ProdcutType,
                    ProductTypeRef = new ProductTypeRef(command.ProdcutType)
                };

                var result = await _db.AddAsync(newProduct, cancellationToken);
                var rows = await _db.SaveChangesAsync(cancellationToken);

                return new Result
                {
                    ProductId = (result.State != Microsoft.EntityFrameworkCore.EntityState.Added || rows == 0) ?
                                result.Entity.Id :
                                null
                };
            }
        }
    }
}
