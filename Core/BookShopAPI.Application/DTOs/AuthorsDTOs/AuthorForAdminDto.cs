using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.AuthorsDTOs
{
    public class AuthorForAdminDto : IDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Autobiography { get; set; }
        public string? AuthorPictureUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}