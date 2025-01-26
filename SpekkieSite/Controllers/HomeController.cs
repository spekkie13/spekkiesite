using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SpekkieSite.Models;

namespace SpekkieSite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Music()
    {
        return View();
    }    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}