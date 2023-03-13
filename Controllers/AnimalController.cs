
using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagement.Models.Response;
using ZooManagement.Repositories;

namespace ZooManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    private readonly IAnimalRepo _animals;

    public AnimalController(IAnimalRepo animals)
    {
        _animals = animals;
    }

    [HttpGet("{id}")]
    public ActionResult<AnimalResponse> GetById([FromRoute] int id)
    {
        var animal = _animals.GetById(id);
        return new AnimalResponse(animal);
    }

}
