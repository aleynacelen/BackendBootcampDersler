using System;
using EShop.Services.Abstract;
using EShop.Shared.Dtos.OrderDtos;
using EShop.Shared.Dtos.ResponseDtos;
using Iyzipay.Model;

namespace EShop.Services.Concrete;

public class PaymentManager 
{
    public Task<ResponseDto<Payment>> CheckoutAsync(Payment payment)
    {
        throw new NotImplementedException();
    }

}
