using AutoMapper;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Application.Repositories.LanguageRepositories;
using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.AddBook
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IBookWriteRepository _bookWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ILanguageReadRepository _languageReadRepository;
        private readonly IPublisherReadRepository _publisherReadRepository;

        public AddBookCommandHandler(IUnitOfWork unitOfWork, IBookWriteRepository bookWriteRepository, IAuthorReadRepository authorReadRepository, ICategoryReadRepository categoryReadRepository, IPublisherReadRepository publisherReadRepository, IMapper mapper, IBookReadRepository bookReadRepository, ILanguageReadRepository languageReadRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _bookWriteRepository = bookWriteRepository;
            _authorReadRepository = authorReadRepository;
            _categoryReadRepository = categoryReadRepository;
            _publisherReadRepository = publisherReadRepository;
            _languageReadRepository = languageReadRepository;
        }

        public async Task<BaseResponse> Handle(AddBookCommandRequest request, CancellationToken cancellationToken)
        {
            var isISBNAny = await _bookReadRepository.AnyAsync(x => x.ISBN == request.ISBN);
            if (isISBNAny)
                return new FailNoDataResponse();

            var isNameAny = await _bookReadRepository.AnyAsync(x => x.BookName.ToUpper() == request.BookName.ToUpper());
            if (isNameAny)
                return new FailNoDataResponse();

            var selectedPublisher = await _publisherReadRepository.GetByIdAsync(request.PublisherId, false);
            if (selectedPublisher == null)
                return new FailNoDataResponse();

            var selectedLanguage = await _languageReadRepository.GetByIdAsync(request.LanguageId, false);
            if (selectedLanguage == null)
                return new FailNoDataResponse();

            var addedBook = _mapper.Map<Book>(request);
            List<Category> categoryies = new();
            List<Author> authors = new();

            foreach (int categoryId in request.CategoryIds)
            {
                var category = await _categoryReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == categoryId, false);

                if (category != null)
                    categoryies.Add(category);
            }

            foreach (int authorId in request.AuthorIds)
            {
                var author = await _authorReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == authorId, false);

                if (author != null)
                    authors.Add(author);
            }

            if (authors.Count == 0 || categoryies.Count == 0)
                return new FailNoDataResponse();

            await _bookWriteRepository.AddAsync(addedBook);
            await _unitOfWork.SaveChangesAsync();

            addedBook.Authors = authors;
            addedBook.Categories = categoryies;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}