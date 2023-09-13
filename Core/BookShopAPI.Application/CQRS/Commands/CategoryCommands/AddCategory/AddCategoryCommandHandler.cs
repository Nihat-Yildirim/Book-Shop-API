using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.CategoryCommands.AddCategory
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public AddCategoryCommandHandler(IUnitOfWork unitOfWork, ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedParentCategory = await _categoryReadRepository.GetByIdAsync(request.ParentId, false);

            if (request.ParentId != 0 && selectedParentCategory == null)
                return new FailNoDataResponse();

            if(request.ParentId != 0 && selectedParentCategory.CategoryName == request.Name)
                return new FailNoDataResponse();

            if(request.ParentId == 0)
            {
                var parentCategories = _categoryReadRepository.GetWhere(x => x.ParentId == 0, false);

                if(parentCategories.Select(x => x.CategoryName).Contains(request.Name))
                    return new FailNoDataResponse();
            }

            if(request.ParentId != 0)
            {
                var childCategories = await _categoryReadRepository.GetWhere(x => x.ParentId == request.ParentId).ToListAsync();
                if(childCategories.Select(x => x.CategoryName).Contains(request.Name))
                    return new FailNoDataResponse();
            }

            await _categoryWriteRepository.AddAsync(new() { ParentId  = request.ParentId, CategoryName = request.Name });
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}