using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;   
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        private readonly IProductService _productService;
        public
    }
}
