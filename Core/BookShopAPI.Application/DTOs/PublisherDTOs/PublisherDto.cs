using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.PublisherDTOs
{
    public class PublisherDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PictureUrl { get; set; }
    }
}