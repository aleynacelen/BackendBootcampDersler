using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos;

public class CartUpdateDto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Kullanıcı id boş olamaz")]
    public bool IsDeleted { get; set; }
    [Required(ErrorMessage = "Aktif/Pasif durumu belirtilmelidir")]
    public bool IsActive { get; set; }

}
