using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.AddressDTOs
{
    public class ShortAddressDto : IDto
    {
        public int Id { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Neighbourhood { get; set; }
        public string? OpenAddress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}