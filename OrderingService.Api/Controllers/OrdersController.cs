using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OrderingService.Dal.Models;
using OrderingService.Domain;
using OrderingService.Domain.Orders;
using OrderingService.Domain.Products;

namespace OrderingService.Api.Controllers
{
    /// <summary>
    /// Работа с заказами клиентов.
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IQueryBus _queryBus;
        private readonly ICommandBus _commandBus;
        private readonly IValidator<GetOrdersByClientQuery.Query> _validator;
        private readonly IMemoryCache _memoryCache;

        /// <summary>
        /// Конструктор с DI.
        /// </summary>
        /// <param name="queryBus">Отправка запросов.</param>
        /// <param name="commandBus">Отправка команд.</param>
        /// <param name="validator">Валидатор.</param>
        /// <param name="memoryCache">Реализация кэширования.</param>
        public OrdersController(
            IQueryBus queryBus, 
            ICommandBus commandBus,
            IValidator<GetOrdersByClientQuery.Query> validator,
            IMemoryCache memoryCache)
        {
            _queryBus = queryBus;
            _commandBus = commandBus;
            _validator = validator;
            _memoryCache = memoryCache;
        }

        /// <summary>
        /// Получение заказа по Id.
        /// </summary>
        /// <param name="orderId">Id запрашиваемого заказа.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата с заказом.</returns>
        [HttpGet("{orderId}")]
        public async Task<ActionResult<Order>> GetOrder(
            [FromRoute] Guid orderId,
            CancellationToken cancellationToken)
        {
            var query = new GetQuery.Query
            {
                Id = orderId,
                ResultEntityType = typeof(Order)
            };

            var validationResult = await new GetQuery.Validator().ValidateAsync(query);

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(ModelState);
                return BadRequest(ModelState);
            }

            GetQuery.Result result;

            if (!_memoryCache.TryGetValue(query.Id, out result!))
            {
                result = await _queryBus.Send(query, cancellationToken);

                _memoryCache.Set(query.Id, result);
            }

            var order = result.Entity as Order;

            return order != null ? 
                Ok(order) :
                NotFound(order);
        }

        /// <summary>
        /// Получение заказов клиента отсортированных по дате.
        /// </summary>
        /// <param name="clientId">Guid клиента.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата со списком заказов.</returns>
        [HttpGet("client{clientId}")]
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

            GetOrdersByClientQuery.Result result;

            if (!_memoryCache.TryGetValue(query.ClientId, out result!))
            {
                result = await _queryBus.Send(query, cancellationToken);

                _memoryCache.Set(query.ClientId, result, TimeSpan.FromMinutes(5));
            }

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
                }, cancellationToken);

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

        /// <summary>
        /// Удаление заказа.
        /// </summary>
        /// <param name="orderId">Id заказа.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата команды с успешностью удаления.</returns>
        [HttpDelete("{orderId}")]
        public async Task<ActionResult<DeleteCommand.Result>> DeleteOrder(
            [FromRoute] Guid orderId,
            CancellationToken cancellationToken)
        {
            var command = new DeleteCommand.Command
            {
                Id = orderId,
                Type = typeof(Order)
            };

            var result = await _commandBus.Send(command, cancellationToken);

            return result.Success ?
                Ok(result) :
                Problem(detail: "Операция удаления заказа неуспешна.");
        }
    }
}
