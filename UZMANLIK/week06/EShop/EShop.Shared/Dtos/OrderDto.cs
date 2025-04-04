using System;
using EShop.Shared.ComplexTypes;

namespace EShop.Shared.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public DateTime ApplicationUserId { get; set; }
    public ApplicationUserDto ApplicationUser { get; set; }=new ApplicationUserDto();
    public string? Adress { get; set; }
    public string? City { get; set; }
    public OrderStatusType OrderStatus { get; set; }
    public ICollection<OrderItemDto> OrderItems { get; set; }=new List<OrderItemDto>();

    public decimal TotalAmount => OrderItems.Sum(x => x.Product.Price * x.Quantity);
}
