using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.NeighbourhoodDTOs
{
    public class NeighbourhoodDto : IDto
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public string? Name { get; set; }
    }
}