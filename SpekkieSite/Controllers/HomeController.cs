using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SpekkieSite.Models;

namespace SpekkieSite.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

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
        List<Project> projects =
        [
            new()
            {
                Title = "Spekkie's Stream tools",
                Description = "A bot that allows the user to automate their stream chat, music and much more.",
                ImageUrl = "https://placehold.co/100x100",
                ProjectUrl = "https://github.com/yourusername/project-one"
            },

            new()
            {
                Title = "YouTube to MP3 Converter",
                Description = "A tool to convert a YouTube playlist (or individual songs) to MP3 files",
                ImageUrl = "https://placehold.co/100x100",
                ProjectUrl = "https://github.com/yourusername/project-two"
            }
        ];

        return View(projects);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}