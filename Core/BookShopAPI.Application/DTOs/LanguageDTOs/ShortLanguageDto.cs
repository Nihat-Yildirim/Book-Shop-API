using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.LanguageDTOs
{
    public class ShortLanguageDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}