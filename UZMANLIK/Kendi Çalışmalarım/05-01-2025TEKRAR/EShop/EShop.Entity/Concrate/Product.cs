using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrate;

public class Product:BaseEntity
{
    private Product()
    {
        
    }
    public Product(string name, string description, decimal price, string ımageUrl, int categoryId)
    {
        Name = name;
        Description = description;
        Price = price;
        ImageUrl = ımageUrl;
        CategoryId = categoryId;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; }= new HashSet<ProductCategory>();
    

}

