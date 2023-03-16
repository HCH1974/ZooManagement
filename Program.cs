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
using NLog;
using NLog.Config;
using NLog.Targets;

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

var config = new LoggingConfiguration();
var target = new FileTarget { FileName = @"C:\Training\ZooManagement\Logs\ZooManagement${shortdate}.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
config.AddTarget("File Logger", target);
config.LoggingRules.Add(new LoggingRule("*", NLog.LogLevel.Debug, target));
LogManager.Configuration = config;

var app = builder.Build();

//var host = CreateHostBuilder(args).Build();
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<ZooManagementDbContext>();
context.Database.EnsureCreated();

if (!context.Enclosure.Any())
{
    var enclosures = SampleEnclosures.GetEnclosures();
    context.Enclosure.AddRange(enclosures);
    context.SaveChanges();
}
if (!context.Species.Any())
{
    var species = SampleSpecies.GetSpecies();
    context.Species.AddRange(species);
    context.SaveChanges();
}
if (!context.SpeciesToEnclosure.Any())
{
    var speciesToEnclosures = SampleSpeciesToEnclosure.GetSpeciesToEnclosures();
    context.SpeciesToEnclosure.AddRange(speciesToEnclosures);
    context.SaveChanges();
}
if (!context.Animal.Any())
{
    var animals = SampleAnimals.GetAnimals();
    context.Animal.AddRange(animals);
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