using System;
using System.Text.Json.Serialization;

namespace EShop.MVC.Models;

public class CategoryModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("createDate")]    
    public DateTime CreateDate { get; set; }
    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; }
    [JsonPropertyName("description")]   
    public string Description { get; set; }

}
