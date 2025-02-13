using System;

namespace SikayetVar.Models.Entities;

public class Comments
{
    public int Id { get; set; }
    public int ComplaintId { get; set; }
    public int UserId { get; set; }
    public string CommentText { get; set; }
    public DateTime CreatedAt { get; set; }
}
