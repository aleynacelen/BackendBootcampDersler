using System;
using EfCore.Entity.Abstract;

namespace EfCore.Entity.Concarete;

public class Category:BaseEntity
{
public string Description { get; set; }
public ICollection<ProductCategory> ProductCategories { get; set; }
}
