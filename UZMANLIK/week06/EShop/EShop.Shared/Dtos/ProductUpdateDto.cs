using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EShop.Shared.Dtos;

public class ProductUpdateDto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Ürün adı boş olamaz")]
    [StringLength(100, ErrorMessage = "Ürün adı 100 karakter olmalıdır")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Ürün özellikleri boş olamaz")]
    [StringLength(5000, ErrorMessage = "Ürün özellikleri 5000 karakter arasında olmalıdır")]
    public string? Properties { get; set; }
    [Required(ErrorMessage = "Ürün fiyatı boş olamaz")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Ürün fiyatı 0'dan büyük olmalıdır")]
    public decimal? Price { get; set; }
    [Required(ErrorMessage = "Ürün resmi boş olamaz")]
    public IFormFile? Image { get; set; }
    [Required(ErrorMessage = "Silinme durumu belirtilmelidir")]
    public bool IsDeleted { get; set; }
    [Required(ErrorMessage = "Aktif/Pasif durumu belirtilmelidir")]
    public bool IsActive { get; set; }

    [Required(ErrorMessage = "Her ürün en az bir kategoriye ait olmalıdır")]
    public ICollection<int> CategoryIds { get; set; } = new List<int>();
}
 


