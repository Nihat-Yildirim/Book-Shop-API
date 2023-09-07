using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CategoryDTOs
{
    public class ShortCategoryDto : IDto
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
    }
}