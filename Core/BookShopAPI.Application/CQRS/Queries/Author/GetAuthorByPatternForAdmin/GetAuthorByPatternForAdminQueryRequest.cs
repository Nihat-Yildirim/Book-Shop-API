using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByPatternForAdmin
{
    public class GetAuthorByPatternForAdminQueryRequest : IRequest<BaseDataResponse<List<AuthorForAdminDto>>>
    {
        public string? Pattern { get; set; }
    }
}