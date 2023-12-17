using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookIdForAdmin
{
    public class GetCommentsByBookIdForAdminQueryRequest : IRequest<BaseDataResponse<ResultCommentForAdminDto>>
    {
        public int BookId { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}