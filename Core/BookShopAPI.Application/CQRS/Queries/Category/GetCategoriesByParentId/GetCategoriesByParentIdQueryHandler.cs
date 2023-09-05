using AutoMapper;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.Category.GetCategoriesByParentId
{
    public class GetCategoriesByParentIdQueryHandler : IRequestHandler<GetCategoriesByParentIdQueryRequest, BaseDataResponse<List<CategoryDto>>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public GetCategoriesByParentIdQueryHandler(IMapper mapper, ICategoryReadRepository categoryReadRepository)
        {
            _mapper = mapper;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<BaseDataResponse<List<CategoryDto>>> Handle(GetCategoriesByParentIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedCategories = await _categoryReadRepository.GetWhere(x => x.ParentId == request.ParentId && x.DeletedDate == null, false).ToListAsync();
            var responseCategories = _mapper.Map<List<CategoryDto>>(selectedCategories);

            return new SuccessDataResponse<List<CategoryDto>>(responseCategories);
        }
    }
}