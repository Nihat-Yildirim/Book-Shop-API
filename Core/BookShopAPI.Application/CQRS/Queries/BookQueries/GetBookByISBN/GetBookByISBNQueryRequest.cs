﻿using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByISBN
{
    public class GetBookByISBNQueryRequest : IRequest<BaseDataResponse<BookDetailDto>>
    {
        public string? ISBN { get; set; }
    }
}