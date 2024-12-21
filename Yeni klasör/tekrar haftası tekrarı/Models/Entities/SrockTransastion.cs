using System;

namespace tekrar_haftası_tekrarı.Models.Entities;

public class SrockTransastion
{public int Id { get; set; }
public int ProducktId { get; set; }
public int TransactionTypeId { get; set; }  
public DateTime TransactionDate { get; set; }
public int Quantity { get; set; }
public string Note { get; set; }
public bool IsDeleted { get; set; }

}

