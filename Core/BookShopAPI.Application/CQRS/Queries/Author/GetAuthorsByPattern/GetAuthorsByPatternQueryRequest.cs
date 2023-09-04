using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAuthorsByPattern
{
    public class GetAuthorsByPatternQueryRequest : IRequest<BaseDataResponse<List<AuthorDto>>>
    {
        public string? Pattern { get; set; }
    }
}