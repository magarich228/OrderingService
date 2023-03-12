using FluentValidation.AspNetCore;
using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OrderingService.Dal.Models;
using OrderingService.Domain;
using OrderingService.Domain.Dtos;
using OrderingService.Domain.Products;

namespace OrderingService.Api.Controllers
{
    /// <summary>
    /// Работа с товарами магазина.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IQueryBus _queryBus;
        private readonly ICommandBus _commandBus;
        private readonly IMemoryCache _memoryCache;

        /// <summary>
        /// Конструктор с DI.
        /// </summary>
        /// <param name="queryBus">Отправка запросов.</param>
        /// <param name="memoryCache">Реализация кэширования.</param>
        /// <param name="commandBus">Отправка команд.</param>
        public ProductsController(
            IQueryBus queryBus,
            IMemoryCache memoryCache,
            ICommandBus commandBus)
        {
            _queryBus = queryBus;
            _memoryCache = memoryCache;
            _commandBus = commandBus;
        }

        /// <summary>
        /// Получение товара по Id.
        /// </summary>
        /// <param name="productId">Id запрашиваемого товара.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата с полученным товаром.</returns>
        [HttpGet("{productId}")]
        public async Task<ActionResult<Product>> GetProduct(
            [FromRoute] Guid productId, 
            CancellationToken cancellationToken)
        {
            var query = new GetQuery.Query
            {
                Id = productId,
                ResultEntityType = typeof(Product)
            };

            var validationResult = await new GetQuery.Validator().ValidateAsync(query);

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(ModelState);
                return BadRequest(ModelState);
            }

            GetQuery.Result result;

            if (!_memoryCache.TryGetValue(productId, out result!))
            {
                result = await _queryBus.Send(query, cancellationToken);

                _memoryCache.Set(query.Id, result);
            }

            var product = result.Entity as Product;

            return product != null? 
                Ok(product) :
                NotFound(product);
        }

        /// <summary>
        /// Получение всех товаров с возможностью фильтрации по типу товара,
        /// минимальному количеству на складе и сортировки по цене.
        /// </summary>
        /// <param name="query">Запрос со свойствами для фильтрации, сортировки.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Список товаров.</returns>
        [HttpGet]
        public async Task<ActionResult<GetProductsQuery.Result>> GetProductsByFilter(
            [FromQuery] GetProductsQuery.Query query, 
            CancellationToken cancellationToken)
        {
            var result = await _queryBus.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Получение товаров заказа.
        /// </summary>
        /// <param name="query">Объект запроса с Guid заказа.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>
        /// Список объектов <see cref="ProductsWithQuantityInOrderDto"/>
        /// с товаром и количеством товара в заказе.
        /// </returns>
        [Authorize]
        [HttpGet("order{OrderId}")]
        public async Task<ActionResult<GetOrderProductsQuery.Result>> GetOrderProducts(
            [FromRoute] GetOrderProductsQuery.Query query,
            CancellationToken cancellationToken)
        {
            GetOrderProductsQuery.Result result;

            if (!_memoryCache.TryGetValue(query.OrderId, out result!))
            {
                result = await _queryBus.Send(query, cancellationToken);

                _memoryCache.Set(query.OrderId, result);
            }

            return Ok(result);
        }

        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        /// <param name="command">Объект команды добавления с данными о новом товаре.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата команды с Id нового товара.</returns>
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<AddProductCommand.Result>> AddProduct(
            [FromBody] AddProductCommand.Command command, 
            CancellationToken cancellationToken)
        {
            var result = await _commandBus.Send(command, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Удаление товара.
        /// </summary>
        /// <param name="productId">Id товара.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата с успехом операции.</returns>
        [Authorize]
        [HttpDelete("{productId}")]
        public async Task<ActionResult<DeleteCommand.Result>> DeleteProduct(
            [FromRoute] Guid productId,
            CancellationToken cancellationToken)
        {
            var command = new DeleteCommand.Command
            {
                Id = productId,
                Type = typeof(Product)
            };

            var result = await _commandBus.Send(command, cancellationToken);

            return result.Success ? 
                Ok(result) :
                Problem(detail: "Операция удаления товара неуспешна.");
        }
    }
}
