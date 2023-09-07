using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.AuthorsDTOs
{
    public class ShortAuthorDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}