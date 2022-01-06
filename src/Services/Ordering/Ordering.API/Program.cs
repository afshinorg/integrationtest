using Ordering.API.Extensions;
using Ordering.Application;
using Ordering.Infrastructure;
using Ordering.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// MassTransit-RabbitMQ Configuration
builder.Services.AddMassTransit(config =>
{
    config.UsingRabbitMq((context, config) =>
    {
        config.Host(builder.Configuration["EventBusSettings:HostAddress"]);
        // config.Host("amqp://guest:guest@localhost:5672"); // Local connection
    });
});
builder.Services.AddMassTransitHostedService();

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// All the injected classes
builder.Services.AddApplicationServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ordering.API v1"));
}
// Seed data
app.MigrateDatabase<OrderContext>((context, services) =>
{
    var logger = services.GetService<ILogger<OrderContextSeed>>();
    OrderContextSeed
        .SeedAsync(context, logger)
        .Wait();
});


app.UseAuthorization();

app.MapControllers();

app.Run();
