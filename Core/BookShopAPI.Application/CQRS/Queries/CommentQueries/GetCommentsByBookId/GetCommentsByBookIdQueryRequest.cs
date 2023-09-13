using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookId
{
    public class GetCommentsByBookIdQueryRequest : IRequest<BaseDataResponse<List<CommentDto>>>
    {
        public int BookId { get; set; }
    }
}