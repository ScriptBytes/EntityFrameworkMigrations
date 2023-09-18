using EFMigrationsDemo.Data;
using EFMigrationsDemo.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EFMigrationsDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonsController : ControllerBase
{

    private readonly ILogger<PersonsController> _logger;
    private readonly IConfiguration configuration;

    public PersonsController(
        ILogger<PersonsController> logger,
        IConfiguration configuration
        )
    {
        _logger = logger;
        this.configuration = configuration;
    }

    [HttpGet(Name = "GetPersons")]
    public IEnumerable<Person> Get()
    {
        using (var context = new EFDemoDbContext(configuration))
        {
            return context.Persons.ToList();
        }
    }
}