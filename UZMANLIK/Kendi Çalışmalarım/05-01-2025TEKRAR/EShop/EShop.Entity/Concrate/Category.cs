using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrate;

public class Category:BaseEntity
{
public string Name { get; set; }
public string Description { get; set; }
}
