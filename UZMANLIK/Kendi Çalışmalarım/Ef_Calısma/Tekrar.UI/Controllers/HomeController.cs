using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tekrar.UI.Models;

namespace Tekrar.UI.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }

    
}
