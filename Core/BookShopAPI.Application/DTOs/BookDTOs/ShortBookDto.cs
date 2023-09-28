using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BookDTOs
{
    public class ShortBookDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}