using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace EShop.Shared.Dtos;

public class CategoryCreateDto
{
   [Required(ErrorMessage ="Kategori adı zorunludur")]
   [StringLength(100, ErrorMessage = "Kategori adı en fazla 100 karakter olmalıdır")]
    public string? Name { get; set; }
    [StringLength(300, ErrorMessage = "Kategori açıklamsı en fazla 300 karakter olmalıdır")]

    public string? Description { get; set; }

    public IFormFile? Image { get; set; }

}
