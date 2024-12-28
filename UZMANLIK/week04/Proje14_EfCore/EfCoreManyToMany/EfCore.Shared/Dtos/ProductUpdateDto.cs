using System;

namespace EfCore.Shared.Dtos;

public class ProductUpdateDto
{
    [req]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Properties { get; set; }
    public decimal Price { get; set; }
    public int[] CategoryIds { get; set; }
      public List<CategoryDto>? CategoryList { get; set; }
}
