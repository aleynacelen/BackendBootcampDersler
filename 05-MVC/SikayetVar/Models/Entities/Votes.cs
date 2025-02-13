using System;

namespace SikayetVar.Models.Entities;

public class Votes
{
    public int UserId { get; set; }
    public int ComplaintId { get; set; }
    public string VoteType { get; set; }
    public DateTime CreatedAt { get; set; }

}
