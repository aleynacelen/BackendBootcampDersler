using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos;

public class OrderItenCreateDto
{
[Required(ErrorMessage ="Ürün id si gereklidir.")]
public int ProductId { get; set; }
[Required(ErrorMessage = "Ürün adedi gereklidir.")]
[Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Adet 0'dan büyük olmalıdır.")]
public decimal UnitPrice { get; set; }
[Required(ErrorMessage = "Ürün adedi gereklidir.")]
[Range(1, 100, ErrorMessage = "En fazla 100 adet ürün girilmelidir.")]
protected int Quantity { get; set; }
}
