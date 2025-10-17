using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
using MyLandingPage.Models;

namespace MyLandingPage.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        List<MyApplications> myApplications = new()
          {
            new MyApplications { MyAppId = 1, MyApplicationName = "User Management", MyAppUrl = "https://localhost:7054", IsActive = true,Description="User Management Application for creating users .Accessible to admin only" ,IconCss="bi bi-people",ColorClass="bg-primary text-white", OpenInNewTab = true },
            new MyApplications { MyAppId = 2, MyApplicationName = "Dashboard", MyAppUrl = "", IsActive = true,IconCss="bi bi-bar-chart",ColorClass="bg-success text-white" },
            new MyApplications { MyAppId = 3, MyApplicationName = "Order Management", MyAppUrl = "", IsActive = true ,IconCss="bi bi-bag",ColorClass="bg-warning text-dark"},
        };
        ViewBag.myApplications = myApplications;
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
