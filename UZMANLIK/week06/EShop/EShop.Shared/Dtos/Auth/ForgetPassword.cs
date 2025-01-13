using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos.Auth;

public class ForgetPassword
{ [Required(ErrorMessage = "Email zorunludur")]
[EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]

    public string? Email { get; set; }

}
