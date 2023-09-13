using BookShopAPI.Application.Repositories.CommentRatingRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteCommentRating
{
    public class DeleteCommentRatingCommandHandler : IRequestHandler<DeleteCommentRatingCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICommentRatingReadRepository _commentRatingReadRepository;

        public DeleteCommentRatingCommandHandler(IUnitOfWork unitOfWork, ICommentRatingReadRepository commentRatingReadRepository)
        {
            _unitOfWork = unitOfWork;
            _commentRatingReadRepository = commentRatingReadRepository;
        }

        public async Task<BaseResponse> Handle(DeleteCommentRatingCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedCommentRating = await _commentRatingReadRepository.GetSingleAsync(x => x.UserId == request.UserId && x.Id == request.CommentRatingId && x.DeletedDate == null);
            if (selectedCommentRating == null)
                return new FailNoDataResponse();

            selectedCommentRating.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}