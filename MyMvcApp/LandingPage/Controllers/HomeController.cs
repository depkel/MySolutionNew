using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LandingPage.Models;
using LandingPage.DAL;

namespace LandingPage.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var myapplications = new DataAccessLayer().myApplications;
        ViewBag.myapplications = myapplications;
        return View(myapplications);
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
