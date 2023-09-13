using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByUserId
{
    public class GetCommentsByUserIdQueryRequest : IRequest<BaseDataResponse<List<CommentForAdminDto>>>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
        public int UserId { get; set; }
    }
}