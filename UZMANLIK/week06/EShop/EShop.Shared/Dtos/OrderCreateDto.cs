using System;

namespace EShop.Shared.Dtos;

public class OrderCreateDto
{
     public string ?ApplicationUserId { get; set; }
     public ICollection<OrderItemDto> OrderItem { get; set; }=new List<OrderItemDto>();
     public string ?Adress { get; set; }
     public string ?City { get; set; }  


}
