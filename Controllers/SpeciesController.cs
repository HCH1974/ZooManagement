
using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagement.Models.Response;
using ZooManagement.Repositories;

namespace ZooManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class SpeciesController : ControllerBase
{
    private readonly ISpeciesRepo _species;

    public SpeciesController(ISpeciesRepo species)
    {
        _species = species;
    }

    [HttpGet()]
    public ActionResult<List<string>> GetAllSpecies()
    {
        return _species.GetAllSpecies();
    }

}
