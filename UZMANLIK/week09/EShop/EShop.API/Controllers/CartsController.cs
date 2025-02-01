using EShop.Services.Abstract;
using EShop.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/CARTS")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;
                
         [Authorize]
        [HttpPost]
        public async Task<IActionResult>AddToCartAsync([FromBody] CartItemCreateDto  cartItemCrateDto)
        {
            var response = await _cartService.AddToCartAsync(cartItemCrateDto);
            return Ok(response);
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFromCartAsync(int CartItemId)
        {
            var response = await _cartService.RemoveFromCartAsync(CartItemId);
            return Ok(response);
        }
        [Authorize]
        [HttpPut("quantity/{quantity}")]
        public async Task<IActionResult> ChangeQuantity([FromBody] CartItemUpdateDto cartItemUpdateDto)
        {
            var response = await _cartService.ChangeQuantityAsync(cartItemUpdateDto);
            return Ok(response);
            
            
            
        }
        // [Authorize]
        // [HttpGet("{userId}")]
        // public async Task<IActionResult> GetCartByUserId(int userId)
        // {
        //     var response = await _cartService.GetCartByUserIdAsync(userId);
        //     return Ok(response);
        // }
    }
}
