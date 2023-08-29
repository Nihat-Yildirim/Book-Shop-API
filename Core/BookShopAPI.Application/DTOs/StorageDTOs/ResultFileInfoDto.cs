using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.StorageDTOs
{
    public class ResultFileInfoDto : IDto
    {
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public string? FileExtension { get; set; }
    }
}