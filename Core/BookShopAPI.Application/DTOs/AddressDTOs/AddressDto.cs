using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Application.DTOs.ProvinceDTOs;

namespace BookShopAPI.Application.DTOs.AddressDTOs
{
    public class AddressDto : IDto
    {
        public int Id { get; set; }
        public string? AddressTitle { get; set; }
        public ShortProvinceDto? Province { get; set; }
        public ShortDistrictDto? District { get; set; }
        public ShortNeighbourhoodDto? Neighbourhood { get; set; }
        public string? OpenAddress { get; set; }
        public string? Description { get; set; }
        public bool Selected { get; set; }
    }
}