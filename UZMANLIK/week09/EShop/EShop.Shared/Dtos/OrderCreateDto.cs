using System;
using System.Text.Json.Serialization;

namespace EShop.Shared.Dtos;

public class OrderCreateDto
{
    

    [JsonIgnore]
    public string? ApplicationUserId { get; set; }// dışarıdan gelmeyecek biz bunu içeride kullanacağız
    public ICollection<OrderItenCreateDto> OrderItems { get; set; } = new List<OrderItenCreateDto>();
    public string? Address { get; set; }
    public string? City { get; set; }
    
}
