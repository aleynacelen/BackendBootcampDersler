using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EShop.MVC.Models;

public class RegistorModel
{
[Display(Name ="Ad")]
[Required(ErrorMessage = "Ad boş olamaz")]
[JsonPropertyName("userName")]
public string Name { get; set; }
}
