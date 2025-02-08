using System;
using System.Text.Json.Serialization;

namespace EShop.Shared.Dtos;

public class OrderItemDto
{
    public int Id { get; set; }
    public int OrderId { get; set; }
  
    public int ProductId { get; set; }
    // [JsonIgnore]
    // public ProductDto Product { get; set; } = new ProductDto(); // This is not needed döngüye girebilir.
    public string ?ProductName { get; set; }// Mapping Profile da bunun için ilemler yaparak içini dolduracağız.
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;
}
