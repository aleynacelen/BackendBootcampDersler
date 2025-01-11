using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrate;

public class Category:BaseEntity
{
    public Category(string? name, string? description)
    {
        Name = name;
        Description = description;
    }

    public string ?Name { get; set; }
public string ?Description { get; set; }
public ICollection<ProductCategory> ProductCategories { get; set; }= new HashSet<ProductCategory>();    
}

