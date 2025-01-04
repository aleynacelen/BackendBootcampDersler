using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrate;

public class ProductCategory:BaseEntity
{
    public ProductCategory()
    {
        
    }
    public ProductCategory(int productId, int categoryId)
    {
        ProductId = productId;
        CategoryId = categoryId;
    }

public int ProductId { get; set; }
public Product? Product { get; set; }
public int CategoryId { get; set; }
public Category? Category { get; set; }
}
