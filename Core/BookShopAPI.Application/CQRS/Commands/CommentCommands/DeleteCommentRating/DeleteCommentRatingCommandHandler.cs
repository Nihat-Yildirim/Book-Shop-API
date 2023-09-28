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
        private readonly ICommentRatingWriteRepository _commentRatingWriteRepository;

        public DeleteCommentRatingCommandHandler(IUnitOfWork unitOfWork, ICommentRatingReadRepository commentRatingReadRepository, ICommentRatingWriteRepository commentRatingWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _commentRatingReadRepository = commentRatingReadRepository;
            _commentRatingWriteRepository = commentRatingWriteRepository;
        }

        public async Task<BaseResponse> Handle(DeleteCommentRatingCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedCommentRating = await _commentRatingReadRepository.GetSingleAsync(x => x.UserId == request.UserId && x.Id == request.CommentRatingId && x.DeletedDate == null);
            if (selectedCommentRating == null)
                return new FailNoDataResponse();

            _commentRatingWriteRepository.Remove(selectedCommentRating);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}