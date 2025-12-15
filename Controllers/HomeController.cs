using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMiniApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyMiniApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

   [Authorize]
   public IActionResult Secret()
    {
        return Content("you are logged");
    }
}
