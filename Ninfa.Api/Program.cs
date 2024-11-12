using Microsoft.EntityFrameworkCore;

using Ninfa.DataAccess;
using Ninfa.Integration;
using Ninfa.Logic;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddNinfaIntegrations();
builder.Services.AddNinfaDataAccess();
builder.Services.AddNinfaLogic();
builder.Services.AddDbContext<NinfaDbContext>(dbOptions => dbOptions.UseSqlServer(configuration.GetConnectionString("DConnection")));

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
