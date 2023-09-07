using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorReadRepository _authorReadRepository;

        public UpdateAuthorCommandHandler(IUnitOfWork unitOfWork, IAuthorReadRepository authorReadRepository)
        {
            _unitOfWork = unitOfWork;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedAuthor = await _authorReadRepository.GetByIdAsync(request.AuthorId);

            if (selectedAuthor == null)
                return new FailNoDataResponse();

            if (selectedAuthor.DeletedDate != null)
                return new FailNoDataResponse();

            selectedAuthor.Autobiography = request.Autobiography;
            selectedAuthor.FirstName = request.FirstName;
            selectedAuthor.LastName = request.LastName;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}