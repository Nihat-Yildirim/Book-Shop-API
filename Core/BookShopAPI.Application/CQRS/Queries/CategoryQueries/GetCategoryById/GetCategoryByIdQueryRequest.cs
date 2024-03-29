﻿using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetCategoryById
{
    public class GetCategoryByIdQueryRequest : IRequest<BaseDataResponse<CategoryDto>>
    {
        public int Id { get; set; }
    }
}