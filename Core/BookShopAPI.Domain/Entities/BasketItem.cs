﻿using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class BasketItem : BaseEntity
    {
        public int BasketId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public Basket? Basket { get; set; }
    }
}