using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos;

public class CartCreateDto
{
    [Required(ErrorMessage = "Kullanıcı id boş olamaz")]
    public string? ApplicationUserId { get; set; } 

}
