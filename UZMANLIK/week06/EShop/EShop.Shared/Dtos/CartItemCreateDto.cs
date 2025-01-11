using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos;

public class CartItemCreateDto
{
    [Required(ErrorMessage = "Ürün id boş olamaz")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Sepet id boş olamaz")]
    public int Quantity { get; set; }

}
