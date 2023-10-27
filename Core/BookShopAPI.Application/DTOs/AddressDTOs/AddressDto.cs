using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.AddressDTOs
{
    public class AddressDto : IDto
    {
        public int Id { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? OpenAddress { get; set; }
        public bool Selected { get; set; }
    }
}