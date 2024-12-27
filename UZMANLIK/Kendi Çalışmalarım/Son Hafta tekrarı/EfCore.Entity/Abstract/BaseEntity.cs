using System;

namespace EfCore.Entity.Abstract;

public abstract class BaseEntity
{
public int Id { get; set; }
public string Name { get; set; }
public bool IsDeleted { get; set; }
public DateTime CreateDate { get; set; }
public DateTime ModifiedDate { get; set; }
}
