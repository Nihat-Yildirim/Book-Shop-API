using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Application.DTOs.ProvinceDTOs;

namespace BookShopAPI.Application.DTOs.AddressDTOs
{
    public class AddressForAdminDto
    {
        public int Id { get; set; }
        public string? AddressTitle { get; set; }
        public ShortProvinceDto? Province { get; set; }
        public ShortDistrictDto? District { get; set; }
        public ShortNeighbourhoodDto? Neighbourhood { get; set; }
        public string? PhoneNumber { get; set; }
        public string? OpenAddress { get; set; }
        public string? Description { get; set; }
        public bool Selected { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}