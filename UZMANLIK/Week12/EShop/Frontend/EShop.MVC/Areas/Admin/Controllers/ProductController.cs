using EShop.MVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EShop.MVC.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ActionResult Index()
        {
            return View();
        }

    }
}
