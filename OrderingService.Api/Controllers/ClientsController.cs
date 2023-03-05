using Infrastructure.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderingService.Domain.Clients;

namespace OrderingService.Api.Controllers
{
    /// <summary>
    /// Работа с клиентами магазина.
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IQueryBus _queryBus;

        /// <summary>
        /// Конструктор с DI.
        /// </summary>
        /// <param name="queryBus">Отправка запросов.</param>
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

        /// <summary>
        /// Аутентификация клиента на основе BasicAuthentication.
        /// </summary>
        /// <param name="credentials">Данные клиента.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект данных о клиенте.</returns>
        [AllowAnonymous]
        [HttpPost("auth")]
        public async Task<ActionResult<AuthenticateQuery.Result>> Authenticate(
            [FromBody] AuthenticateQuery.Query credentials, 
            CancellationToken cancellationToken)
        {
            var query = new AuthenticateQuery.Query
            {
                Username = credentials.Username,
                Password = credentials.Password
            };

            var clientWithCredentials = await _queryBus.Send(query, cancellationToken);

            if (clientWithCredentials.ClientWithCredentialsWithoutPassword == null)
            {
                return BadRequest("Некоректное имя пользователя или пароль.");
            }

            return Ok(clientWithCredentials);
        }
    }
}
