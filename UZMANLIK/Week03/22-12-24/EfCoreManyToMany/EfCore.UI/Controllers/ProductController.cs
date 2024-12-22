using Microsoft.AspNetCore.Mvc;

namespace EfCore.UI.Controllers
{
    public class ProductController : Controller
    {
      
        public async Task<ActionResult> Index()
        {
            var products = await _
            return View();
        }

    }
}
