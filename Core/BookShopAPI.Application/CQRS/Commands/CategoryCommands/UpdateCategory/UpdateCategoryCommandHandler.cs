using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CategoryCommands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork, ICategoryReadRepository categoryReadRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedCategory = await _categoryReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == request.CategoryId);
            var parentCategories = await _categoryReadRepository.GetWhere(x => x.Id == request.ParentCategoryId && x.DeletedDate == null, false).ToListAsync();

            if (selectedCategory == null)
                return new FailNoDataResponse();

            if(selectedCategory.Id == request.ParentCategoryId)
                return new FailNoDataResponse();

            if(request.ParentCategoryId != selectedCategory.ParentId)
            {
                if(parentCategories.Count == 0)
                    return new FailNoDataResponse();

                var childCategories = await _categoryReadRepository.GetWhere(x => x.ParentId == request.ParentCategoryId && x.DeletedDate == null, false).ToListAsync();

                if (childCategories.Select(x => x.CategoryName).Contains(request.CategoryName))
                    return new FailNoDataResponse();

                if (parentCategories.Select(x => x.CategoryName).Contains(request.CategoryName))
                    return new FailNoDataResponse();
            }

            selectedCategory.ParentId = request.ParentCategoryId;
            selectedCategory.CategoryName = request.CategoryName;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}