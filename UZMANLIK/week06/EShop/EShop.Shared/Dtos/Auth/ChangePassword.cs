using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos.Auth;

public class ChangePassword
{
    [Required(ErrorMessage = "Email zorunludur")]
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? NewPassword { get; set; }
    public string? ConfirmPassword { get; set; }

}
