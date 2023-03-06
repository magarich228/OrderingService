using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using OrderingService.Api;
using OrderingService.Dal;
using OrderingService.Domain.Clients;
using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddControllers();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
{
    //Решения конфликта имен схем данных
    c.CustomSchemaIds(type => $"{type.DeclaringType}{type.Name}");

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Ordering Service API",
        Description = "Technical test job"
    });

    var basePath = AppDomain.CurrentDomain.BaseDirectory;
    var xmlPath = Path.Combine(basePath, "OrderingService.Api.xml");
    c.IncludeXmlComments(xmlPath);

    c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Description = "BasicAuthentication на основе имя клиента и его пароля.",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Scheme = "basic"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "basic"
                }
            },
            new string[] {} 
        }
    });
});

services.AddTransient<SeedData>();
services.AddDbContext<OrderingContext>(options => options.UseSqlServer(builder.Configuration["localdb"]));

services.AddScoped<ICommandBus, CommandBus>();
services.AddScoped<IQueryBus, QueryBus>();

services.AddMediatR(configure =>
{
    configure.RegisterServicesFromAssemblies(
        typeof(Program).GetTypeInfo().Assembly,
        typeof(GetClientsQuery).GetTypeInfo().Assembly);
});

services.AddValidatorsFromAssemblyContaining<GetClientsQuery.Validator>()
    .AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();

services.AddMemoryCache();

services.AddCors();

services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
services.AddAuthorization();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(c => c
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();