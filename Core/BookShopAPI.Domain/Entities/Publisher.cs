﻿using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Publisher : BaseEntity
    {
        public int PublisherLogoFileId { get; set; }
        public string? Name { get; set; }
        public DateTime DeletedDate { get; set; }

        public File? File { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}