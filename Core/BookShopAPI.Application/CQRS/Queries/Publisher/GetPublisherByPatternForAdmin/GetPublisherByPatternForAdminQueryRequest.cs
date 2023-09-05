﻿using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Publisher.GetPublisherByPatternForAdmin
{
    public class GetPublisherByPatternForAdminQueryRequest : IRequest<BaseDataResponse<List<PublisherForAdminDto>>>
    {
        public string? Pattern { get; set; }
    }
}