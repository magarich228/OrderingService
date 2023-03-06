using Infrastructure.Queries;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using OrderingService.Dal.Models;
using OrderingService.Domain.Clients;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace OrderingService.Api
{
    /// <summary>
    /// Реализация BasicAuthentication.
    /// </summary>
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IQueryBus _queryBus;
        private const string AuthHeaderKey = "Authorization";

        /// <summary>
        /// Конструктор с DI.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="logger"></param>
        /// <param name="encoder"></param>
        /// <param name="clock"></param>
        /// <param name="queryBus"></param>
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options, 
            ILoggerFactory logger, 
            UrlEncoder encoder, 
            ISystemClock clock,
            IQueryBus queryBus) : base(options, logger, encoder, clock)
        {
            _queryBus = queryBus;
        }

        /// <summary>
        /// Асинхронная обработка аутентификации.
        /// </summary>
        /// <returns>Объект результата аутентификации.</returns>
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var endpoint = Context.GetEndpoint();

            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
            {
                return AuthenticateResult.NoResult();
            }

            if (!Request.Headers.ContainsKey(AuthHeaderKey))
            {
                return AuthenticateResult.Fail("Отсутствует Authorization Header");
            }

            ClientCredentials? client;

            try
            {
                client = await ParseClient();
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail($"{ex.Message}");
            }

            if (client == null)
            {
                return AuthenticateResult.Fail("Невалидный Login или Password");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, client.ClientId.ToString()),
                new Claim(ClaimTypes.Name, client.Login)
            };

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }

        private async Task<ClientCredentials?> ParseClient()
        {
            string[] credentials;

            try
            {
                var authenticationHeader = AuthenticationHeaderValue.Parse(Request.Headers[AuthHeaderKey]);
                credentials = Encoding.UTF8
                    .GetString(Convert.FromBase64String(authenticationHeader?.Parameter!))
                    .Split(new[] { ':' }, 2);
            }
            catch
            {
                throw new ApplicationException("Невалидный Authorization Header");
            }

            var query = new AuthenticateQuery.Query
            {
                Username = credentials[0],
                Password = credentials[1],
            };

            return (await _queryBus.Send(query)).ClientWithCredentialsWithoutPassword;
        }
    }
}
