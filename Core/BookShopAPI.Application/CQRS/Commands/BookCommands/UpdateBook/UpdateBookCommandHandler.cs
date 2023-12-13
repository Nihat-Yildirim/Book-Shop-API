using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.LanguageRepositories;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly ILanguageReadRepository _languageReadRepository;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public UpdateBookCommandHandler(IUnitOfWork unitOfWork, IBookReadRepository bookReadRepository, ILanguageReadRepository languageReadRepository, IPublisherReadRepository publisherReadRepository)
        {
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _languageReadRepository = languageReadRepository;
            _publisherReadRepository = publisherReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBook = await _bookReadRepository.GetSingleAsync(x => x.Id == request.BookId && x.DeletedDate == null);
            if (selectedBook == null)
                return new FailNoDataResponse();

            var selectedPublisher = await _publisherReadRepository.GetSingleAsync(x => x.Id == request.PublisherId && x.DeletedDate == null);
            if (selectedPublisher == null)
                return new FailNoDataResponse();

            var selectedLanguage = await _languageReadRepository.GetByIdAsync(request.LanguageId);
            if(selectedLanguage == null)
                return new FailNoDataResponse();

            var isNameAny = await _bookReadRepository.AnyAsync(x => x.BookName == request.BookName && x.Id != request.BookId);
            if(isNameAny)
                return new FailNoDataResponse();

            var isISBNAny = await _bookReadRepository.AnyAsync(x => x.ISBN == request.ISBN && x.Id != request.BookId);
            if(isISBNAny)
                return new FailNoDataResponse();

            selectedBook.BookName = request.BookName;
            selectedBook.PublisherId = request.PublisherId;
            selectedBook.LanguageId = request.LanguageId;
            selectedBook.ISBN = request.ISBN;
            selectedBook.PaperType = request.PaperType;
            selectedBook.SkinType = request.SkinType;
            selectedBook.Dimension = request.Dimension;
            selectedBook.Description = request.Description;
            selectedBook.ReleaseDate = request.ReleaseDate;
            selectedBook.PageOfNumber = request.PageOfNumber;
            selectedBook.Stock = request.Stock;
            selectedBook.Price = request.Price;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}