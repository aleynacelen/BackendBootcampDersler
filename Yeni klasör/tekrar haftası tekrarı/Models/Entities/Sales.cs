using System;

namespace tekrar_haftası_tekrarı.Models.Entities;

public class Sales
{
    public int Id { get; set; }
    public int ProducktId { get; set; }
    public int CustomerId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }  
    public DateTime SaleDate { get; set; }  
    public bool IsDeleted { get; set; }

}
