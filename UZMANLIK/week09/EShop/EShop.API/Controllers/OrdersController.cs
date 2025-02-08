using EShop.Entity.Concrete;
using EShop.Services.Abstract;
using EShop.Shared.ComplexTypes;
using EShop.Shared.ControllerBases;
using EShop.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    [Authorize]
    public class OrdersController : CustomControllerBase
    {
        private readonly IOrderService _orderManager;

        public OrdersController(IOrderService orderManager)
        {
            _orderManager = orderManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] OrderCreateDto orderCreateDto)
        {
            orderCreateDto.ApplicationUserId = GetUserId();
            var response = await _orderManager.AddAsync(orderCreateDto);
            return CreateResult(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetById( int id)
        
        {
            var response = await _orderManager.GetAsync(id);
            return CreateResult(response);

        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()

        {
            var response = await _orderManager.GetAllAsync();
            return CreateResult(response);

        }
        [HttpGet("getall/bystatus")]
        public async Task<IActionResult> GetAllByStayus([FromQuery] OrderStatus orderStatus)

        {
            var userId = GetUserId();
            var response = await _orderManager.GetAllAsync(orderStatus, userId);
            return CreateResult(response);

        }
        [HttpGet("getall/myorders")]
        public async Task<IActionResult> GetAllMyOrders()

        {
            var userId = GetUserId();
            var response = await _orderManager.GetAllAsync(userId);
            return CreateResult(response);

        }
        [HttpGet("getall/bydate")]
        public async Task<IActionResult> GetAllByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)

        {
            var userId = GetUserId();
            var response = await _orderManager.GetAllAsync(startDate, endDate);
            return CreateResult(response);

        }
        [HttpPut("changestatus{orderId}")]
        public async Task<IActionResult> ChangeStatus([FromQuery] OrderStatus orderStatus, [FromQuery] int orderId)

        {
            var response = await _orderManager.UpdateOrderStatusAsync(orderId, orderStatus);
            return CreateResult(response);

        }
        [HttpPut("cancel{orderId}")]
        public async Task<IActionResult> Cancel( [FromQuery] int orderId)

        {
            var response = await _orderManager.CancelOrderAsync(orderId);
            return CreateResult(response);

        }





    }
}
