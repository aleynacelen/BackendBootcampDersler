using System;

namespace Aleyna.Entity.Concrete;

public class Category:BaseEntity
{
    public string? Description { get; set; }
    public ICollection<ProductCategory> ?ProductCategories { get; set; }

}
