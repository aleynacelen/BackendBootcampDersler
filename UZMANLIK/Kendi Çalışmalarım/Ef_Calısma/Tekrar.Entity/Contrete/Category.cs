using System;
using Tekrar.Entity.Abstract;

namespace Tekrar.Entity.Contrate;

public class Category:BaseEntity
{
  public string ?Description { get; set; }
  public IEnumerable<Product> ?Products { get; set; }
}
