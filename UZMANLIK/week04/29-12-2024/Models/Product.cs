using System;

namespace _29_12_2024.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string image { get; set; }
    public Rating Rating { get; set; }

}

