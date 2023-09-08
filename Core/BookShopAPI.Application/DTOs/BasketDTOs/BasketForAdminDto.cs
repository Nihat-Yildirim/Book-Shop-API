using BookShopAPI.Application.DTOs.BasketItemDTOs;
using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BasketDTOs
{
    public class BasketForAdminDto : IDto
    {
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<BasketItemDto>? BasketItems { get; set; }
    }
}