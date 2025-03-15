using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EShop.MVC.Models
{
    public class OrderCreateModel
    {
        [JsonPropertyName("orderItems")]
        public List<OrderItemCreateModel> OrderItems { get; set; } = [];

        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Adres alanı zorunludur!")]
        [JsonPropertyName("address")]
        public string Address { get; set; } = "Zeliha hanım mh. Hanönü Cd. Çember Sk. No:10/9";

        [Display(Name = "Şehir")]
        [Required(ErrorMessage = "Şehir alanı zorunludur!")]
        [JsonPropertyName("city")]
        public string City { get; set; } = "İstanbul";
        public string FirstName { get; set; }="Alex";
        public string LastName { get; set; }="De Souza";
        public string PhoneNumber { get; set; }="5559999444";
        public string IdentityNumber { get; set; }="12345678901";
        public string Email { get; set; }="alexdesoua@gmail.com";
        public string CardHolder { get; set; }="Jasica De Souza";
        public string CardNumber { get; set; }="5873434934034";
        public string ExpiryMonth { get; set; }="12";
        public string ExpiryYear { get; set; }="25";
        public string Cvc { get; set; }="123";
        public string PaymentMethod { get; set; }="CreditCard";

    }
}
