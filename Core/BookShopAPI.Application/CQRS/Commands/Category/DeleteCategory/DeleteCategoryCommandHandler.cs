using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.Category.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public DeleteCategoryCommandHandler(ICategoryReadRepository categoryReadRepository, IUnitOfWork unitOfWork)
        {
            _categoryReadRepository = categoryReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedCategory = await _categoryReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == request.CategoryId);

            if (selectedCategory == null)
                return new FailNoDataResponse();

            var childCategories = await _categoryReadRepository.GetWhere(x => x.ParentId == selectedCategory.Id, false).ToListAsync();

            if(childCategories.Count != 0) 
                return new FailNoDataResponse();

            selectedCategory.DeletedDate = DateTime.Now;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();

        }
    }
}