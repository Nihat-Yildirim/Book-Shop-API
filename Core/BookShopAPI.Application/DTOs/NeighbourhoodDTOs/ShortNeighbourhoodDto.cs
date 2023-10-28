using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.NeighbourhoodDTOs
{
    public class ShortNeighbourhoodDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}