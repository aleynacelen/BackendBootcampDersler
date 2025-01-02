using System;

namespace Aleyna.Entity;

public class BaseEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedDate { get; set; }
}
