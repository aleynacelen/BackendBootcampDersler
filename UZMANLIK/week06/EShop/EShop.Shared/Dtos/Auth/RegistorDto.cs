using System;
using System.ComponentModel.DataAnnotations;
using EShop.Shared.ComplexTypes;

namespace EShop.Shared.Dtos.Auth;

public class RegistorDto
{
    [Required(ErrorMessage = "First Name is required")]
   public string? FirstName { get; set; }
    [Required(ErrorMessage = "Soy isim boş bırakılamaz ")]
    public string? LastName { get; set; }
   
    public string ?Adress { get; set; }
    public string ?City { get; set; }
    public GenderType Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Required(ErrorMessage = "Email boş bırakılamaz")]
    public string ?Email { get; set; }
    public string ?UserName { get; set; }
    [Required(ErrorMessage = "Password boş bırakılamaz")]
    public string ?Password { get; set; }
    [Required(ErrorMessage = "Confirm Password boş bırakılamaz")]
    [Compare("Password",ErrorMessage = "Şifrelr aynı değil")]
    public string ?ConfirmPassword { get; set; }
    public string Role { get; set; }="User";

}
