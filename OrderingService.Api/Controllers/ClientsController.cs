using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderingService.Domain.Clients;
using System.Runtime.InteropServices;

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
        private readonly ICommandBus _commandBus;

        /// <summary>
        /// Конструктор с DI.
        /// </summary>
        /// <param name="queryBus">Отправка запросов.</param>
        /// <param name="commandBus">Отправка команд.</param>
        public ClientsController(
            IQueryBus queryBus,
            ICommandBus commandBus)
        {
            _queryBus = queryBus;
            _commandBus = commandBus;
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
            var clientWithCredentials = await _queryBus.Send(credentials, cancellationToken);

            if (clientWithCredentials.ClientWithCredentialsWithoutPassword == null)
            {
                return BadRequest("Некоректное имя пользователя или пароль.");
            }

            return Ok(clientWithCredentials);
        }

        /// <summary>
        /// Регистрация нового клиента.
        /// </summary>
        /// <param name="client">Данные клиента.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Id и имя пользователя нового клиента.</returns>
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<RegisterClientCommand.Result>> Register(
            [FromBody] RegisterClientCommand.Command client,
            CancellationToken cancellationToken)
        {
            var result = await _commandBus.Send(client, cancellationToken);

            return Ok(result);
        }
    }
}
