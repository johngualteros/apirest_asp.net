using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using apirest_asp.net.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<apirest_aspnetContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("apirest_aspnetContext") ?? throw new InvalidOperationException("Connection string 'apirest_aspnetContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
