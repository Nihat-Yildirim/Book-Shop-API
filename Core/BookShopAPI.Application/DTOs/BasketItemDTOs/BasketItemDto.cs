using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.DTOs.PublisherDTOs;

namespace BookShopAPI.Application.DTOs.BasketItemDTOs
{
    public class BasketItemDto : IDto
    {
        public int BasketItemId { get; set; }
        public int BookId { get; set; }
        public ShortPublisherDto? Publisher { get; set; }
        public List<ShortAuthorDto>? Authors { get; set; }
        public string? BookName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string? BookPictureUrl { get; set; }
    }
}