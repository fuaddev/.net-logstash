
using Serilog;
using Serilog.Formatting.Compact;
using System.Net.Sockets;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, loggerConfiguration) =>
{
    loggerConfiguration
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .WriteTo.Udp(builder.Configuration.GetValue<string>("LogStash:host")!, builder.Configuration.GetValue<int>("LogStash:port"), AddressFamily.InterNetwork,
        new CompactJsonFormatter());
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
