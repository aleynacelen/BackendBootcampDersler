using System;
using System.Text.Json.Serialization;

namespace EShop.MVC.Models;

public class ProductModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("createDate")]    
    public DateTime CreateDate { get; set; }
    [JsonPropertyName("isDeleted")]
    public bool IsDeleted { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("price")]
    public decimal Price { get; set; }
    [JsonPropertyName("ımageUrl")]
    public string ImageUrl { get; set; }
    [JsonPropertyName("description")]

    public string Description { get; set; }
    public int CategoryId { get; set; }

}
