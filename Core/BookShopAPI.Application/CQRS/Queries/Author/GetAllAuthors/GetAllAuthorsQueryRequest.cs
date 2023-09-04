using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAllAuthors
{
    public class GetAllAuthorsQueryRequest : IRequest<BaseDataResponse<List<AuthorDto>>>
    {
    }
}