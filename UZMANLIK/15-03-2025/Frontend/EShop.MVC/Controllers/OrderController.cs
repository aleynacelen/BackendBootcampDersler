using EShop.MVC.Models;
using EShop.MVC.Services.Abstract;
using EShop.MVC.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EShop.MVC.Controllers
{
    public class OrderController : Controller
    {
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
                    Quantity=x.Quantity,
                    UnitPrice=x.Product.Price
                }).ToList()
                return View(orderCreateModel);
            }
        }

    }
}
