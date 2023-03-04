using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
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
