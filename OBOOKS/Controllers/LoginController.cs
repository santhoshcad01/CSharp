using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OBOOKS.Models;

namespace OBOOKS.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    
     public IActionResult Register()
    {
        return View();
    }
     public IActionResult Aboutus()
    {
        return View();
    }
     public IActionResult Contactus()
    {
        return View();
    }

     public IActionResult Books()
    {
        return View();
    }
     public IActionResult Categories()
    {
        return View();
    }
     public IActionResult Authors()
    {
        return View();
    }


    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
