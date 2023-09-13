using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteComment
{
    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly ICommentReadRepository _commentReadRepository;

        public DeleteCommentCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, ICommentReadRepository commentReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _commentReadRepository = commentReadRepository;
        }

        public async Task<BaseResponse> Handle(DeleteCommentCommandRequest request, CancellationToken cancellationToken)
        {
            bool anyUser = await _userReadRepository.AnyAsync(x => x.Id == request.UserId && x.DeletedDate == null);
            if (!anyUser)
                return new FailNoDataResponse();

            var selectedComment = await _commentReadRepository.GetSingleAsync(x => x.Id == request.CommentId && x.UserId == request.UserId && x.DeletedDate == null);
            if(selectedComment == null)
                return new FailNoDataResponse();

            selectedComment.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}