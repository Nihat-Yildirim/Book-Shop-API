using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BasketItemDTOs
{
    public class BasketItemDto : IDto
    {
        public int BasketItemId { get; set; }
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public string? BookPictureUrl { get; set; }
    }
}