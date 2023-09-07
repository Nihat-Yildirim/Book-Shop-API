using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.PublisherDTOs
{
    public class ShortPublisherDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}