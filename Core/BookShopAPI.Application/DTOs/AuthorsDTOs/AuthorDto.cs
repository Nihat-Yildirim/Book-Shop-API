using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.AuthorsDTOs
{
    public class AuthorDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Autobiography { get; set; }
        public string? PictureUrl { get; set; }
    }
}