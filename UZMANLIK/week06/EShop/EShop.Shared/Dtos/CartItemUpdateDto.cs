using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos;

public class CartItemUpdateDto

{ 
    [Required(ErrorMessage = "Ürün id boş olamaz")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Ürün adedi boş olamaz")]
  public int Quantity { get; set; }

}
