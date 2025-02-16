using System;
using EShop.MVC.Models;
using EShop.MVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NToastNotify;

namespace EShop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IToastNotification _toaster;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _categoryService.GetAllActivesAsync(true);
            if (!response.IsSuccessful)
            {
              _toaster.AddErrorToastMessage(response.Error);
              return View( new List<CategoryModel>());
            }
            return View();
        }
    }
}
