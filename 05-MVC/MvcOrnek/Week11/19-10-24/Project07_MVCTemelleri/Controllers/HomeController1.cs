using Microsoft.AspNetCore.Mvc;

namespace Project07_MVCTemelleri.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
