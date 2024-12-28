using EfCore.Business.Abstract;
using EfCore.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EfCore.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<ActionResult> Index()
        {
            var products = await _productService.GetProductsAsync();
            return View(products ?? new List<ProductDto>());
        }

        [NonAction]
        private async Task<List<CategoryDto>> GetCategoryListAsync()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            var categoryList = categories
                .Select(x => new CategoryDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            return categoryList;
        }
        public async Task<ActionResult> Create()
        {
            ProductCreateDto productCreateDto = new()
            {
                CategoryList = await GetCategoryListAsync()
            };
            return View(productCreateDto);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProductCreateDto productCreateDto)
        {
            if (ModelState.IsValid)
            {
                var product = await _productService.CreateAsync(productCreateDto);
                return RedirectToAction("Index");
            }

            productCreateDto.CategoryList = await GetCategoryListAsync();
            return View(productCreateDto);
        }
        [HttpGet]
        public async Task<ActionResult> Update(int id)
        {
            var product = await = _productService.GetByIdAsync(id);
                var ProductDto = new ProductUpdateDto
                { Id=product.Id,
                Name =product.Name,
                Price =product.Price,
                Properties=product.Properties,
                CategoryList=await GetCategoryListAsync();
                CategoryIds=product.Categories.Select(x=>x.Id).ToArray()

                };
               
            return View(productUpdateDto);

        }
        [HttpPost]
        public async Task<ActionResult> Update(ProductUpdateDto productUpdateDto)
        {
         if(ModelState.IsValid && productUpdateDto.CategoryIds.Any())       
         {
            await _productService.Update.Async(product.ProductUpdateDto);
            return RedirectToAction("Index");
            if(productUpdateDto.CategoryIds== productUpdateDto.CategoryIds.Any())
            {
                 ViewBag.CategoryErrorMessage=
            productUpdateDto.CatgoryIds.Any() ? " " : "Kategori boş bırakılamaz"
            

            }
            productUpdateDto.CategoryLis=await GetCategoryListAsync();
           
            return View(productUpdateDto);

         }
        }

    }
}
