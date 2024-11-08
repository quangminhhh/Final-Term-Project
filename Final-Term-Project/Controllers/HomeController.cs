using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Final_Term_Project.Models;

namespace Final_Term_Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Requirement_1()
    {
        return View();
    }
    public IActionResult Requirement_2()
    {
        return View();
    }
    public IActionResult Requirement_3()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}