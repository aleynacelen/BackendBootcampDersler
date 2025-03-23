using EShop.MVC.Models;
using EShop.MVC.Services.Abstract;
using EShop.MVC.Services.Concrete;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace EShop.MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;
        private readonly IAuthService _authService;
        private readonly CartService _cartServices;
        public OrderController(CartService cartServices)
        {
            _cartServices = cartServices;
        }
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Checkout()
        {
            var cart = (await _cartServices.GetCartAsync()).Data;
            OrderCreateModel orderCreateModel= new(){
                OrderItems= cart!.CartItems.Select(x=> new OrderItemCreateModel{
                    ProductId=x.ProductId,
                    Quantity=x.Quantity
                      
                }).ToList()
            };
                return View(orderCreateModel);
            }
        }
    
    }

