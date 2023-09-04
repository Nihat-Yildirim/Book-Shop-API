using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAuthorById
{
    public class GetAuthorByIdQueryRequest : IRequest<BaseDataResponse<AuthorDto>>
    {
        public int Id { get; set; }
    }
}