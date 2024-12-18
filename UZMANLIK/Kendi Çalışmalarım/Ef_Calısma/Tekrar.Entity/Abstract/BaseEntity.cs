using System;

namespace Tekrar.Entity.Abstract;

public class BaseEntity
{
public int Id { get; set; }
public string? Name { get; set; }
public bool IsDeleted { get; set; }
public DateTime CreateDate { get; set; }
public DateTime ModifiedDate { get; set; }

}
