using System;

namespace SikayetVar.Models.Entities;

public class Companies
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string DescriptionComp { get; set; }
    public string Category { get; set; }
    public DateTime  CreatedAt { get; set; }

}
