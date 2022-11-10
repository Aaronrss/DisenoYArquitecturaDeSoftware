using Microsoft.AspNetCore.Mvc;

namespace APIadapter.Controllers;

[ApiController]
[Route("[controller]")]

public class AdapterController : ControllerBase
{

    [HttpGet(Name = "GetAdapter")]
    public string Get()
    {
        return "Hola mundo";
    }

}