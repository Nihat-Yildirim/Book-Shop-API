using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetChildComments
{
    public class GetChildCommentsQueryRequest : IRequest<BaseDataResponse<List<CommentDto>>>
    {
        public int ParentCommentId { get; set; }
    }
}