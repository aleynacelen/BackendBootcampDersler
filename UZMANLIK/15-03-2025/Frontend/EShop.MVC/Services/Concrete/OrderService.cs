using System;
using EShop.MVC.Models;
using EShop.MVC.Services.Abstract;

namespace EShop.MVC.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IHttpClientService _httpClientService;

        public OrderService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public Task<ResponseModel<OrderModel>> AddAsync(OrderCreateModel orderCreateModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<NoContent>> ChangeOrderStatusAsync(int id, OrderStatus orderStatus)
        {
            var response = await _httpClientService.PutAsync<object, ResponseModel<NoContent>>($"orders/{id}/status?orderStatus={orderStatus}", null!);
            Console.WriteLine("DURUM: " + response.IsSuccessful);
            return response!;
        }

        public Task<ResponseModel<List<OrderModel>>> GetAllAsync()
        {
            var response = _httpClientService.GetAsync<ResponseModel<List<OrderModel>>>("orders");
            return response!;
        }

        public Task<ResponseModel<List<OrderModel>>> GetAllAsync(OrderStatus orderStatus)
        {
            var response = _httpClientService.GetAsync<ResponseModel<List<OrderModel>>>($"orders?status={orderStatus}");
            return response!;
        }

        public Task<ResponseModel<List<OrderModel>>> GetAllByDateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<OrderModel>>> GetAllMyAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<OrderModel>>> GetAllMyAsync(OrderStatus orderStatus)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<OrderModel>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
