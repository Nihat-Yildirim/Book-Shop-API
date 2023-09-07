using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;

        public DeleteBookCommandHandler(IBookReadRepository bookReadRepository, IUnitOfWork unitOfWork)
        {
            _bookReadRepository = bookReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBook = await _bookReadRepository.GetByIdAsync(request.Id);

            if (selectedBook == null)
                return new FailNoDataResponse();

            if (selectedBook.DeletedDate != null)
                return new FailNoDataResponse();

            selectedBook.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}