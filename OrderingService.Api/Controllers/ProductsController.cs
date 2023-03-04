using Infrastructure.Queries;
using Microsoft.AspNetCore.Mvc;
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

        public ProductsController(IQueryBus queryBus)
        {
            _queryBus = queryBus;
        }

        /// <summary>
        /// Получение товаров с возможностью фильтрации по типу товара,
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
        [HttpGet("{OrderId}")]
        public async Task<ActionResult<GetOrderProductsQuery.Result>> GetOrderProducts(
            [FromRoute] GetOrderProductsQuery.Query query,
            CancellationToken cancellationToken)
        {
            var result = await _queryBus.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
