﻿using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Category.AddCategory
{
    public class AddCategoryCommandRequest : IRequest<BaseResponse>
    {
        public int ParentId { get; set; }
        public string? Name { get; set; }
    }
}