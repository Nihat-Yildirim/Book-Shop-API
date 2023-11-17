using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Application.DTOs.BasketDTOs;
using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.OrderDTOs
{
    public class OrderDto : IDto
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public ShortAddressDto? Address { get; set; }
        public ShortBasketDto? Basket { get; set; }
        public float TotalPayment { get; set; }
        public bool Pay { get; set; }
        public bool Comfirm { get; set; }
        public bool Send { get; set; }
    }
}