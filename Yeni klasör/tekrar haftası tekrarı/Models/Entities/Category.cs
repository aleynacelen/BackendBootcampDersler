using System;

namespace tekrar_haftası_tekrarı.Models.Entities;

public class Category
{
public int Id { get; set; }
public string? Name { get; set; }
public string ?Description { get; set; }
public bool IsDeleted { get; set; }
public DateTime CreateAt { get; set; }  
public DateTime UpdateAt { get; set; }
}
