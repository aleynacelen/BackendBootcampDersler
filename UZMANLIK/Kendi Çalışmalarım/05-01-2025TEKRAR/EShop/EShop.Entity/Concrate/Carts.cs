using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrate;

public class Carts:BaseEntity
{
    public Carts(int productId, int userId, int quantity)
    {
        ProductId = productId;
        UserId = userId;
        Quantity = quantity;
    }

    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Quantity { get; set; }
    public Product? Product { get; set; }
    

}
