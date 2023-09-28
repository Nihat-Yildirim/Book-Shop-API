using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedBookUserComment
{
    public class GetSelectedBookUserCommentQueryRequest : IRequest<BaseDataResponse<ShortCommentDto>>
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
    }
}