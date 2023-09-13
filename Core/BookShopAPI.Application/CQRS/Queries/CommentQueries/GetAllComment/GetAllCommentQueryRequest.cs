using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetAllComment
{
    public class GetAllCommentQueryRequest : IRequest<BaseDataResponse<List<CommentForAdminDto>>>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}