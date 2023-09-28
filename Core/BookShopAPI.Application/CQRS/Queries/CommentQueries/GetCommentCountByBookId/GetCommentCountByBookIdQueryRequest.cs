using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentCountByBookId
{
    public class GetCommentCountByBookIdQueryRequest : IRequest<BaseDataResponse<CountDto>>
    {
        public int BookId { get; set; }
    }
}