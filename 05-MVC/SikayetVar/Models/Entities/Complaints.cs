using System;

namespace SikayetVar.Models.Entities;

public class Complaints
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }

}
