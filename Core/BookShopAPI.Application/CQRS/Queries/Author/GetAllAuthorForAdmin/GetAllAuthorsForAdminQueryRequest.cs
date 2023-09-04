using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAllAuthorForAdmin
{
    public class GetAllAuthorsForAdminQueryRequest : IRequest<BaseDataResponse<List<AuthorForAdminDto>>>
    {
    }
}