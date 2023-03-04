using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.AspNetCore.Mvc;
using OrderingService.Domain.Orders;
using OrderingService.Domain.Products;

namespace OrderingService.Api.Controllers
{
    /// <summary>
    /// Работа с заказами клиентов.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IQueryBus _queryBus;
        private readonly ICommandBus _commandBus;
        private readonly IValidator<GetOrdersByClientQuery.Query> _validator;

        public OrdersController(
            IQueryBus queryBus, 
            ICommandBus commandBus,
            IValidator<GetOrdersByClientQuery.Query> validator)
        {
            _queryBus = queryBus;
            _commandBus = commandBus;
            _validator = validator;
        }

        /// <summary>
        /// Получение заказов клиента отсортированных по дате.
        /// </summary>
        /// <param name="clientId">Guid клиента.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата со списком заказов.</returns>
        [HttpGet("{clientId}")]
        public async Task<ActionResult<GetOrdersByClientQuery.Result>> GetOrdersByClientIdAsc(
            [FromRoute] Guid clientId,
            CancellationToken cancellationToken)
        {
            var query = new GetOrdersByClientQuery.Query()
            {
                ClientId = clientId
            };

            var validationResult = await _validator.ValidateAsync(query, cancellationToken);

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(ModelState);

                return BadRequest(ModelState);
            }

            var result = await _queryBus.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Создание заказа.
        /// </summary>
        /// <param name="command">
        /// Объект команды для создания заказа со списком Id товаров,
        /// со списком их соответствующего количества в заказе и Id клиента.
        /// </param>
        /// <param name="cancellationToken"></param>
        /// <returns>Id созданного заказа.</returns>
        [HttpPost]
        public async Task<ActionResult<CreateOrderCommand.Result>> CreateOrder(
            [FromBody] CreateOrderCommand.Command command, 
            CancellationToken cancellationToken)
        {
            var quantitiesInStock = new List<int>();

            for (int i = 0; i < command.ProductsInOrderIds.Count; i++)
            {
                var quantitytInStock = await _queryBus.Send(new GetProductQuantityQuery.Query()
                {
                    ProductId = command.ProductsInOrderIds[i]
                });

                if (quantitytInStock.StockQuantity == null)
                {
                    return BadRequest($"Не найден товар с Id:{command.ProductsInOrderIds[i]}");
                }

                if (quantitytInStock.StockQuantity < command.OrderProductsQuantities[i])
                {
                    return BadRequest($"Недостаточно товара с Id: {command.ProductsInOrderIds[i]} " +
                        $"на складе: {quantitytInStock}, запрашиваемое: {command.OrderProductsQuantities[i]}");
                }

                quantitiesInStock.Add(quantitytInStock.StockQuantity.Value);
            }

            var result = await _commandBus.Send(command, cancellationToken);

            return Ok(result);
        }
    }
}
