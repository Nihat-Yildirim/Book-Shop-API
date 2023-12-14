using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.BookSearchDataRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookSearchDataCommands.AddBookSearchData
{
    public class AddBookSearchDataCommandHandler : IRequestHandler<AddBookSearchDataCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IBookSearchDataWriteRepository _bookSearchDataWriteRepository;

        public AddBookSearchDataCommandHandler(IUnitOfWork unitOfWork, IBookReadRepository bookReadRepository, IBookSearchDataWriteRepository bookSearchDataWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _bookSearchDataWriteRepository = bookSearchDataWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddBookSearchDataCommandRequest request, CancellationToken cancellationToken)
        {
            bool isBookExists = await _bookReadRepository.AnyAsync(x => x.Id == request.BookId && x.DeletedDate == null);
            if (!isBookExists)
                return new FailNoDataResponse();

            BookSearchData bookSearchData = new();
            bookSearchData.BookId = request.BookId;

            await _bookSearchDataWriteRepository.AddAsync(bookSearchData);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}