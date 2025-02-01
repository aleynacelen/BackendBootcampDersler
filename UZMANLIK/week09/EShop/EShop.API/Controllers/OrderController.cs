using EShop.Services.Abstract;
using EShop.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/order")]
    [ApiController]
    
    public class OrderController : ControllerBase
    {
        
        private readonly IOrderService _orderManager;
        
        public OrderController(IOrderService orderManager)
        {
            _orderManager = orderManager;
        }
        [Authorize]
        [HttpPost]
      public async Task<IActionResult> AddOrderAsync(OrderCreateDto orderCreateDto)
      {
          var response = await _orderManager.AddAsync(orderCreateDto);
          return Ok(response);
      }
       
n
    }
}
