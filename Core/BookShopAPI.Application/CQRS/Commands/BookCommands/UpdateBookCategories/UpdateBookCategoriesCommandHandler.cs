using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookCategories
{
    public class UpdateBookCategoriesCommandHandler : IRequestHandler<UpdateBookCategoriesCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public UpdateBookCategoriesCommandHandler(IBookReadRepository bookReadRepository, ICategoryReadRepository categoryReadRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateBookCategoriesCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBook = await _bookReadRepository.Table.Include(x => x.Categories).SingleOrDefaultAsync(x => x.Id == request.BookId && x.DeletedDate == null);
            if (selectedBook == null)
                return new FailNoDataResponse();

            List<Category> categories = new();
            foreach (var id in request.CategoryIds)
            {
                var selectedAuthor = await _categoryReadRepository.GetSingleAsync(x => x.Id == id && x.DeletedDate == null, false);
                categories.Add(selectedAuthor);
            }

            if (categories.Count == 0)
                return new FailNoDataResponse();

            List<Category> beforeCategories = selectedBook.Categories.ToList();
            foreach (Category category in categories)
                if (!selectedBook.Categories.Any(x => x.Id == category.Id))
                    selectedBook.Categories.Add(category);

            foreach (Category category in beforeCategories)
                if (!categories.Any(x => x.Id == category.Id))
                    selectedBook.Categories.Remove(category);

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}