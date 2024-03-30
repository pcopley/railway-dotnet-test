using System.Diagnostics;
using lib1;
using Microsoft.AspNetCore.Mvc;
using web1.Models;

namespace web1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly Class1 _class1;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

        _logger.Log(LogLevel.Information, "Home controller");
    }

    public IActionResult Index()
    { 
        _logger.Log(LogLevel.Information, "Index");
        
        _class1.Test();
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}