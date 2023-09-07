using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByPattern
{
    public class GetAuthorByPatternQueryRequest : IRequest<BaseDataResponse<List<AuthorDto>>>
    {
        public string? Pattern { get; set; }
    }
}