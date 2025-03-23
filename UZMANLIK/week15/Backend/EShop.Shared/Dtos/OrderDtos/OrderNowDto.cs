using System.Text.Json.Serialization;

namespace EShop.Shared.Dtos.OrderDtos
{
    public class OrderNowDto
    {
        [JsonIgnore]
        public string? ApplicationUserId { get; set; }
        public ICollection<OrderItemCreateDto> OrderItems { get; set; } = [];
        public string? Address { get; set; }
        public string? City { get; set; }

    }
}
