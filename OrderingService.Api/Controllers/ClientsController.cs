using Infrastructure.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderingService.Domain.Clients;

namespace OrderingService.Api.Controllers
{
    /// <summary>
    /// Работа с клиентами магазина.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IQueryBus _queryBus;

        public ClientsController(IQueryBus queryBus)
        {
            _queryBus = queryBus;
        }

        /// <summary>
        /// Получение всех клиентов.
        /// </summary>
        /// <param name="cancellationToken">Токен томены операции.</param>
        /// <returns>Результат запроса со списком клиентов.</returns>
        [HttpGet]
        public async Task<ActionResult<GetClientsQuery.Result>> GetClients(CancellationToken cancellationToken)
        {
            var result = await _queryBus.Send(new GetClientsQuery.Query(), cancellationToken);

            return Ok(result);
        }
    }
}
