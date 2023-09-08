using BookShopAPI.Application.DTOs.BasketItemDTOs;
using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BasketDTOs
{
    public class BasketDto : IDto
    {
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public List<BasketItemDto>? BasketItems { get; set; }
    }
}