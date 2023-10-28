using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.ProvinceDTOs
{
    public class ShortProvinceDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}