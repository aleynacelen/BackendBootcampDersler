using System;

namespace Entities;

public class Post:BaseEntity
{

public string? Title { get; set; }
public string? Content { get; set; }
public int CategoryId { get; set; }
public Category ?Category { get; set; }
} 

