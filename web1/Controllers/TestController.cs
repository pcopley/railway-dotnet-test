using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : Controller
{
    public string Get()
    {
        return "test";
    }
}