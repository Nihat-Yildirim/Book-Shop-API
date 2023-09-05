using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CategoryDTOs
{
    public class CategoryDto : IDto
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string? CategoryName { get; set; }
    }
}