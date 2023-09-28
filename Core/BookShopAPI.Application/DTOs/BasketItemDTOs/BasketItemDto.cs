using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BasketItemDTOs
{
    public class BasketItemDto : IDto
    {
        public int BasketItemId { get; set; }
        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public string? BookName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string? BookPictureUrl { get; set; }
    }
}