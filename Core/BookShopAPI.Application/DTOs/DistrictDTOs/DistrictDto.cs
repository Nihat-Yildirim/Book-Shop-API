using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.DistrictDTOs
{
    public class DistrictDto : IDto
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public string? Name { get; set; }
    }
}