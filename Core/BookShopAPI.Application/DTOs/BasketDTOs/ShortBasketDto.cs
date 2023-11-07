using BookShopAPI.Application.DTOs.BasketItemDTOs;
using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BasketDTOs
{
    public class ShortBasketDto : IDto
    {
        public int BasketId { get; set; }
        public List<ShortBasketItemDto>? BasketItems { get; set; }
    }
}