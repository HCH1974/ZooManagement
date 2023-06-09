
using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagement.Models.Response;
using ZooManagement.Models.Request;
using ZooManagement.Repositories;
using NLog;

namespace ZooManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    private readonly IAnimalRepo _animals;
    private static readonly NLog.ILogger Logger = LogManager.GetCurrentClassLogger();
    public AnimalController(IAnimalRepo animals)
    {
        _animals = animals;
    }

    [HttpGet("api/get-animal/{id}")]
    public ActionResult<AnimalResponse> GetById([FromRoute] int id)
    {
        var animal = _animals.GetById(id);
        return new AnimalResponse(animal);
    }

    [HttpGet("")]
    public ActionResult<AnimalListResponse> Search([FromQuery] AnimalSearchRequest searchRequest)
    {
        var animals = _animals.Search(searchRequest);
        var animalCount = _animals.Count(searchRequest);
        return AnimalListResponse.Create(searchRequest, animals, animalCount);
    }

    [HttpPost("")]
    public void CreateAnimal(AnimalRequest animalRequest)
    {
        _animals.CreateAnimal(animalRequest);
        Logger.Info("New Animal successfully created.");
    }
}
