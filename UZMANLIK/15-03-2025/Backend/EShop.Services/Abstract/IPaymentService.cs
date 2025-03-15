using System;
using EShop.Shared.Dtos.OrderDtos;
using EShop.Shared.Dtos.ResponseDtos;
using Iyzipay.Model;

namespace EShop.Services.Abstract;

public interface IPaymentService
{
    Task<ResponseDto<Payment>> CheckoutAsync(OrderNowDto orderNowDto);

}
