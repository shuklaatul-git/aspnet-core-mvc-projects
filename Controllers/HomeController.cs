using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using popup_in_mvc.Models;

namespace popup_in_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string param1, string param2)
    {
        ViewBag.Param1 = param1;
        ViewBag.Param2 = param2;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Popup(string param1, string param2)
    {
        ViewBag.Param1 = param1;
        ViewBag.Param2 = param2;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
