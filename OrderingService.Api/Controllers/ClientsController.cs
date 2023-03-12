using FluentValidation.AspNetCore;
using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OrderingService.Dal.Models;
using OrderingService.Domain;
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
        private readonly ICommandBus _commandBus;
        private readonly IMemoryCache _memoryCache;

        private const string AllClientsCacheKey = "allclients";

        /// <summary>
        /// Конструктор с DI.
        /// </summary>
        /// <param name="queryBus">Отправка запросов.</param>
        /// <param name="commandBus">Отправка команд.</param>
        /// <param name="memoryCache">Реализация кэширования.</param>
        public ClientsController(
            IQueryBus queryBus,
            ICommandBus commandBus,
            IMemoryCache memoryCache)
        {
            _queryBus = queryBus;
            _commandBus = commandBus;
            _memoryCache = memoryCache;
        }

        /// <summary>
        /// Получение клиента по Id.
        /// </summary>
        /// <param name="clientId">Id запрашиваемого клиента.</param>
        /// <param name="cancellationToken">Токен отмены операции</param>
        /// <returns>Объект клиента.</returns>
        [HttpGet("{clientId}")]
        public async Task<ActionResult<Client>> GetClient(
            [FromRoute] Guid clientId, 
            CancellationToken cancellationToken)
        {
            var query = new GetQuery.Query
            {
                Id = clientId,
                ResultEntityType = typeof(Client)
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

            var client = result.Entity as Client;

            return client != null ?
                Ok(client) :
                NotFound(client);
        }

        /// <summary>
        /// Получение всех клиентов.
        /// </summary>
        /// <param name="cancellationToken">Токен томены операции.</param>
        /// <returns>Результат запроса со списком клиентов.</returns>
        [HttpGet]
        public async Task<ActionResult<GetClientsQuery.Result>> GetClients(CancellationToken cancellationToken)
        {
            GetClientsQuery.Result result;

            if (!_memoryCache.TryGetValue(AllClientsCacheKey, out result!))
            { 
                result = await _queryBus.Send(new GetClientsQuery.Query(), cancellationToken);

                _memoryCache.Set(AllClientsCacheKey, result);
            }

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

            _memoryCache.Remove(AllClientsCacheKey);

            return Ok(result);
        }

        /// <summary>
        /// Удаление клиента.
        /// </summary>
        /// <param name="clientId">Id клиента.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объект результата команды с успешностью команды.</returns>
        [HttpDelete("{clientId}")]
        public async Task<ActionResult<DeleteCommand.Result>> DeleteClient(
            [FromRoute] Guid clientId,
            CancellationToken cancellationToken)
        {

            var command = new DeleteCommand.Command
            {
                Id = clientId,
                Type = typeof(Client)
            };

            var result = await _commandBus.Send(command, cancellationToken);

            return result.Success ?
                Ok(result) :
                Problem(detail: "Операция удаления клиента неуспешна.");
        }
    }
}
