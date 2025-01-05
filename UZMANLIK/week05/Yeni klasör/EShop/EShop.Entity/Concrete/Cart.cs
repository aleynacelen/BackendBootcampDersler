using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrete;

public class Cart : BaseEntity
{
    private Cart()
    {
    }
    public Cart(string? applicationUserId)
    {
        ApplicationUserId = applicationUserId;
    }
    public string? ApplicationUserId { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }
    public ICollection<CartItem>? CartItems { get; set; } = new List<CartItem>();
}
//Entityler temel olarak iki şey barındırırlar birincisi propertyler ve ikincisi constructorlar.
//Propertyler veritabanındaki tabloların sütunlarına karşılık gelirler.
//Constructorlar ise bu propertyleri set etmek için kullanılır.
//POKO classlar olarak adlandırılan bu classlar sadece propertylerden oluşur ve hiçbir işlem yapmazlar.
////POCO classların başka bir özelliği ise inheritance almamalarıdır.