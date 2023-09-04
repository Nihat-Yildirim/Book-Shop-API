﻿using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthor
{
    public class DeleteAuthorCommandRequest : IRequest<BaseResponse>
    {
        public int AuthorId { get; set; }
    }
}