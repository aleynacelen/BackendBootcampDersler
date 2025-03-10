using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrete;

public class OrderItem:BaseEntity
{
    private OrderItem()
    {
        
    }
    public OrderItem(int orderId, int productId, decimal unitPrice, int quantity)
    {
        OrderId = orderId;
        ProductId = productId;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    protected Order? Order { get; set; }
    
    protected Product ?Product { get; set; }
  

}
