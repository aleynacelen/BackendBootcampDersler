using System;

namespace Aleyna.Entity.Concrete;

public class Product:BaseEntity
{
    public string ? Properties { get; set; }
    public decimal Price { get; set; }
    public bool IsThere { get; set; }
    public ICollection<ProductCategory> ?ProductCategories { get; set; } 

}
