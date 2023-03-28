using Microsoft.AspNetCore.Mvc;

namespace Greg.Api.Controllers;

[ApiController]
[Route("Home")]
public class HomeController : ControllerBase
{
    [HttpGet(Name = "GetHome")]
    public string Get()
    {
        return "Home";
    }
}