using ZooManagement;
using ZooManagement.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ZooManagement.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "zoo", Version = "v1" });
            });
builder.Services.AddDbContext<ZooManagementDbContext>(options =>
{
    options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
    options.UseSqlite("Data Source=zoomanagement.db");
});

builder.Services.AddTransient<IAnimalRepo, AnimalRepo>();
builder.Services.AddTransient<ISpeciesRepo, SpeciesRepo>();

var app = builder.Build();

//var host = CreateHostBuilder(args).Build();
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<ZooManagementDbContext>();
context.Database.EnsureCreated();

if (!context.Animal.Any())
{
    var animals = SampleAnimals.GetAnimals();
    context.Animal.AddRange(animals);
    context.SaveChanges();
}
if (!context.Species.Any())
{
    var species = SampleSpecies.GetSpecies();
    context.Species.AddRange(species);
    context.SaveChanges();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "zoo v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();