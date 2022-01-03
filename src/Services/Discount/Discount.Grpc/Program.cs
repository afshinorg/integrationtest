using Discount.Grpc.Extensions;
using Discount.Grpc.Services;
// using Discount.Grpc.Services;

var builder = WebApplication.CreateBuilder(args);

// Register injected interfaces into services for Grpc
builder.Services.AddAutoMapper(typeof(Program).Assembly);
// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<DiscountService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
// Seed data
app.MigrateDatabase<Program>();
app.Run();

