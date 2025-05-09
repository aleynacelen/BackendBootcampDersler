using System;
using System.ComponentModel.DataAnnotations;

namespace LearnifyStockApp.Models.ViewModels.CategoryViewModels;

public class UpdateCategoryViewModel
{
    public int Id { get; set; }

    [Display(Name = "Kategori Adı")]
    [Required(ErrorMessage = "Bu alan zorunludur.")]
    [MinLength(3, ErrorMessage = "Bu alan en az 3 karakter uzunluğunda olmalıdır.")]
    public string? Name { get; set; }

    [Display(Name = "Kategori Açıklaması")]
    [Required(ErrorMessage = "Bu alan zorunludur.")]
    [MinLength(10, ErrorMessage = "Bu alan en az 10 karakter uzunluğunda olmalıdır.")]
    public string? Description { get; set; }

    [Display(Name = "Son Güncellenme Tarihi:")]
    public DateTime UpdatedAt { get; set; }
}
