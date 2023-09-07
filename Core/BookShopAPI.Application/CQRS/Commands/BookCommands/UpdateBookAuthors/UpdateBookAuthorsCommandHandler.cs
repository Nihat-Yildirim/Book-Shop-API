using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookAuthors
{
    public class UpdateBookAuthorsCommandHandler : IRequestHandler<UpdateBookAuthorsCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IAuthorReadRepository _authorReadRepository;

        public UpdateBookAuthorsCommandHandler(IBookReadRepository bookReadRepository, IAuthorReadRepository authorReadRepository, IUnitOfWork unitOfWork)
        {
            _bookReadRepository = bookReadRepository;
            _authorReadRepository = authorReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponse> Handle(UpdateBookAuthorsCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBook = await _bookReadRepository.Table.Include(x => x.Authors).SingleOrDefaultAsync(x => x.Id == request.BookId && x.DeletedDate == null);
            if (selectedBook == null) 
                return new FailNoDataResponse();

            List<Author> authors = new();
            foreach(var id in request.AuthorIds)
            {
                var selectedAuthor = await _authorReadRepository.GetSingleAsync(x => x.Id == id && x.DeletedDate == null, false);
                authors.Add(selectedAuthor);
            }

            if(authors.Count == 0)
                return new FailNoDataResponse();

            List<Author> beforeAuthors = selectedBook.Authors.ToList();
            foreach (Author author in authors)
                if(!selectedBook.Authors.Any(x => x.Id == author.Id))
                    selectedBook.Authors.Add(author);

            foreach(Author author in beforeAuthors)
                if(!authors.Any(x => x.Id == author.Id))
                    selectedBook.Authors.Remove(author);

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}