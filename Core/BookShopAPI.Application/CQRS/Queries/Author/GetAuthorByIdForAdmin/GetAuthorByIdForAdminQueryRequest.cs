using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByIdForAdmin
{
    public class GetAuthorByIdForAdminQueryRequest : IRequest<BaseDataResponse<AuthorForAdminDto>>
    {
        public int Id { get; set; }
    }
}