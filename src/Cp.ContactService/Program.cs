using Cp.ContactService.Data.Context;
using Cp.ContactService.Data.Repositories;
using Cp.ContactService.Services;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();

// Add context
builder.Services.AddDbContext<ContactContext>();

// Add repository
builder.Services.AddScoped<IContactRepository, ContactRepository>();

builder.Services.AddCors(options => {
    options.AddPolicy("cors", policy => {
        policy.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin().WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<ContactService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
