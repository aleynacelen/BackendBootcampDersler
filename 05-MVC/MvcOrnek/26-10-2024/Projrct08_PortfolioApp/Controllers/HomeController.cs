using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Projrct08_PortfolioApp.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }


}
