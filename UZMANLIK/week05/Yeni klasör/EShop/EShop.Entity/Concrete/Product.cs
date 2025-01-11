using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrete;

public class Product : BaseEntity
{
    private Product()
    {

    }
    public Product(string name, string properties, decimal price, string imageUrl)
    {
        Name = name;
        Properties = properties;
        Price = price;
        ImageUrl = imageUrl;
    }

    public string Name { get; set; } = string.Empty;
    public string Properties { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();//bu satırı yazma sebebi productun bir çok kategorisi olabilir ve bu kategorileri tutmak için bir liste oluşturduk.
}
