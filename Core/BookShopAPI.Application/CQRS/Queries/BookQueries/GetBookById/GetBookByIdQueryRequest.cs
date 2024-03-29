﻿using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookById
{
    public class GetBookByIdQueryRequest : IRequest<BaseDataResponse<BookDetailDto>>
    {
        public int Id { get; set; }
    }
}