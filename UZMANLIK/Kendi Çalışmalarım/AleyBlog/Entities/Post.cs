using System;

namespace Entities;

public class Post
{
public int Id { get; set; }
public string? Title { get; set; }
public string? Content { get; set; }
public DateTime CreatedDate { get; set; }
public int CategoryId { get; set; }
public Category ?Category { get; set; }
} 

