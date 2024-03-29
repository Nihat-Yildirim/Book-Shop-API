﻿using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.AddBook
{
    public class AddBookCommandRequest : IRequest<BaseResponse>
    {
        public int PublisherId { get; set; }
        public int LanguageId { get; set; }
        public ICollection<int>? CategoryIds { get; set; }
        public ICollection<int>? AuthorIds { get; set; }
        public string? BookName { get; set; }
        public string? ISBN { get; set; }
        public string? PaperType { get; set; }
        public string? SkinType { get; set; }
        public string? Dimension { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PageOfNumber { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}