using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrate;

public class Category:BaseEntity
{
    public Category()//Efc ile çalışırken default constructor olmalıdır.
    {
        
    }
    public Category(string name, string imageUrl)
    {
        Name = name;
        ImageUrl = imageUrl;
    }

    public string Name { get; set; } = string.Empty;
   
    public string ImageUrl { get; set; }=string.Empty;
    public string? Description { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>(); //[] ;    //navigasyon property



}
