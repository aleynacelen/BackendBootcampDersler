 using System;
using Tekrar.Entity.Abstract;

namespace Tekrar.Entity.Contrate;

public class Product:BaseEntity
{
public string? Properties { get; set; }
public decimal Price { get; set; }
public int CategoryId { get; set; }
public Category? Category { get; set; }
}
