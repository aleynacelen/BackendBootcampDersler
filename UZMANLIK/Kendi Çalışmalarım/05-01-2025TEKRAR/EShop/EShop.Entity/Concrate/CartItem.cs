using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrate;

public class CartItem:BaseEntity

{
    public CartItem(int categoryId, int productId)
    {
        CategoryId = categoryId;
        ProductId = productId;
    }

    public int CategoryId { get; set; }
    public int ProductId { get; set; }
    public Carts Carts { get; set; }
    public Product Product { get; set; }  
}
