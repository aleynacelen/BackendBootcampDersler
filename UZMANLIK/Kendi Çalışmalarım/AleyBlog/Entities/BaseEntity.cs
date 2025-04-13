using System;

namespace Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    

}
