using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos;

public class CartItemUpdateDto
{
    [Required(ErrorMessage = "Sepet id'si zorunludur.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Ürün miktarı zorunludur.")]
    public int Quantity { get; set; }
}
