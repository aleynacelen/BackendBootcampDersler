using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace Project05_MVCTemelleri.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();

    }

}
