using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FFVSP.Models;

namespace FFVSP.Controllers;

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

       public IActionResult Shop_Gategory()
    {
        return View();
    }

      public IActionResult Groceries()
    {
        return View();
    }
       public IActionResult Primium_Furits()
    {
        return View();
    }
        public IActionResult vagetable()
    {
        return View();
    }

    public IActionResult Fresh_Chicken()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
