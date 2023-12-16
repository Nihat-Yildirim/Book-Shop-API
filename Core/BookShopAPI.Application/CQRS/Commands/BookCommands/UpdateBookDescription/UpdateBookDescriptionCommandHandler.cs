using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookDescription
{
    public class UpdateBookDescriptionCommandHandler : IRequestHandler<UpdateBookDescriptionCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;

        public UpdateBookDescriptionCommandHandler(IUnitOfWork unitOfWork, IBookReadRepository bookReadRepository)
        {
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateBookDescriptionCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBook = await _bookReadRepository.GetByIdAsync(request.BookId, true);
            if (selectedBook == null)
                return new FailNoDataResponse();

            selectedBook.Description = request.Description;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}