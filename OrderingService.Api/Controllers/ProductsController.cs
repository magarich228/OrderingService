using FluentValidation.AspNetCore;
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
        private readonly IMemoryCache _memoryCache;

        /// <summary>
        /// Конструктор с DI.
        /// </summary>
        /// <param name="queryBus">Отправка запросов.</param>
        /// <param name="memoryCache">Реализация кэширования.</param>
        public ProductsController(
            IQueryBus queryBus,
            IMemoryCache memoryCache)
        {
            _queryBus = queryBus;
            _memoryCache = memoryCache;
        }

        /// <summary>
        /// Получение товара по Id.
        /// </summary>
        /// <param name="productId">Id запрашиваемого товара.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата с полученным товаром.</returns>
        [HttpGet("{ProductId}")]
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
        [HttpGet("{OrderId}")]
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
    }
}
