using EShop.Shared.ControllerBases;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class IProducktController : CustomControllerBase
    {
        private readonly IProductServices _productManager;
        public ProductController(IProductServices productManager)
        {
            productManager = _productManager;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(ProductCreateDto productCreateDto)
        {
            var response = await _productManager.AddAsync(productCreateDto);
            return CreateActionResultInstance(response);
        }
    }
    {
        private readonly IProductServices _productManager;
        pıblic ProductController (ProductServices productManager)
        {
            productManager = _productManager;

        }
        [HttpPost]
         public async Task<IActionResult> AddAsync(ProductCreateDto);

    }
}
