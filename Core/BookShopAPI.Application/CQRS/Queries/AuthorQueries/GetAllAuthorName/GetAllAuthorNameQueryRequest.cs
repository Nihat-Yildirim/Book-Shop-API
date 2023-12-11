using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthorName
{
    public class GetAllAuthorNameQueryRequest : IRequest<BaseDataResponse<List<ShortAuthorDto>>>
    {
    }
}