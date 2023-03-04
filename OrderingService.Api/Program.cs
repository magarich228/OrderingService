using FluentValidation;
using FluentValidation.AspNetCore;
using Infrastructure.Commands;
using Infrastructure.Queries;
using Microsoft.EntityFrameworkCore;
using OrderingService.Dal;
using OrderingService.Domain.Clients;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //Решения конфликта имен схем данных
    c.CustomSchemaIds(type => $"{type.DeclaringType}{type.Name}");

    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "Ordering Service API",
        Description = "Technical test job"
    });

    var basePath = AppDomain.CurrentDomain.BaseDirectory;
    var xmlPath = Path.Combine(basePath, "OrderingService.Api.xml");
    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddTransient<SeedData>();
builder.Services.AddDbContext<OrderingContext>(options => options.UseSqlServer(builder.Configuration["localdb"]));

builder.Services.AddScoped<ICommandBus, CommandBus>();
builder.Services.AddScoped<IQueryBus, QueryBus>();

builder.Services.AddMediatR(configure =>
{
    configure.RegisterServicesFromAssemblies(
        typeof(Program).GetTypeInfo().Assembly,
        typeof(GetClientsQuery).GetTypeInfo().Assembly);
});

builder.Services.AddValidatorsFromAssemblyContaining<GetClientsQuery.Validator>()
    .AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();

builder.Services.AddMemoryCache();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();