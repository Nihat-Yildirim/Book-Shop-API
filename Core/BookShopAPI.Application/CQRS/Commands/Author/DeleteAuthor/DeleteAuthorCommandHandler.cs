using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthor
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorReadRepository _authorReadRepository;

        public DeleteAuthorCommandHandler(IAuthorReadRepository authorReadRepository, IUnitOfWork unitOfWork)
        {
            _authorReadRepository = authorReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponse> Handle(DeleteAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedAuthor = await _authorReadRepository.GetSingleAsync(x => x.Id == request.AuthorId);

            if (selectedAuthor == null)
                return new FailNoDataResponse();

            selectedAuthor.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}