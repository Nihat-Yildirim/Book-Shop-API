using BookShopAPI.Application.DTOs.CommentRatingDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedCommentRating
{
    public class GetSelectedCommentRatingQueryRequest : IRequest<BaseDataResponse<CommentRatingDto>>
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
    }
}