using BookShopAPI.Application.Repositories.CommentRatingRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.UpdateCommentRating
{
    public class UpdateCommentRatingCommandHandler : IRequestHandler<UpdateCommentRatingCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICommentRatingReadRepository _commentRatingReadRepository;

        public UpdateCommentRatingCommandHandler(IUnitOfWork unitOfWork, ICommentRatingReadRepository commentRatingReadRepository)
        {
            _unitOfWork = unitOfWork;
            _commentRatingReadRepository = commentRatingReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateCommentRatingCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedCommentRating = await _commentRatingReadRepository.GetSingleAsync(x => x.UserId == request.UserId && x.Id == request.CommentRatingId && x.DeletedDate == null);
            if (selectedCommentRating == null)
                return new FailNoDataResponse();

            selectedCommentRating.Useful = request.Useful;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}