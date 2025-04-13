using System;

namespace Entities;

public class Category:BaseEntity
{
    
    public string? CategoryName { get; set; }
    public List<Post> ?Posts{get; set;}
    

}
