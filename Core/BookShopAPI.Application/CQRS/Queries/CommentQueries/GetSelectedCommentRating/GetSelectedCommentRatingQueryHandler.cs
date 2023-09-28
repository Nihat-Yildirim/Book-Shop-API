using BookShopAPI.Application.DTOs.CommentRatingDTOs;
using BookShopAPI.Application.Repositories.CommentRatingRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CommentQueries.GetSelectedCommentRating
{
    public class GetSelectedCommentRatingQueryHandler : IRequestHandler<GetSelectedCommentRatingQueryRequest, BaseDataResponse<CommentRatingDto>>
    {
        private readonly ICommentRatingReadRepository _commentRatingReadRepository;

        public GetSelectedCommentRatingQueryHandler(ICommentRatingReadRepository commentRatingReadRepository)
        {
            _commentRatingReadRepository = commentRatingReadRepository;
        }

        public async Task<BaseDataResponse<CommentRatingDto>> Handle(GetSelectedCommentRatingQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedCommentRating = await _commentRatingReadRepository.GetSingleAsync(x => x.CommentId == request.CommentId && x.UserId == request.UserId && x.DeletedDate == null);
            if(selectedCommentRating == null)
                return new SuccessDataResponse<CommentRatingDto>();

            CommentRatingDto commentRatingDto = new()
            {
                CommentRatingId = selectedCommentRating.Id,
                Useful = selectedCommentRating.Useful,
            };

            return new SuccessDataResponse<CommentRatingDto>(commentRatingDto);
        }
    }
}