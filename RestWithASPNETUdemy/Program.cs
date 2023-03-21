
using RestWithASPNETUdemy.Services;
using RestWithASPNETUdemy.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Dependency Injection
builder.Services.AddScoped<IPersonService, PersonServiceImplamentation>();

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
