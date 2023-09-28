using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookId
{
    public class GetCommentsByBookIdQueryRequest : IRequest<BaseDataResponse<ResultCommentDto>>
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}