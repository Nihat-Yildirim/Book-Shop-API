﻿using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.PublisherDTOs
{
    public class PublisherForAdminDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PictureUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}