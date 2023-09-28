using AutoMapper;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetParentCategories
{
    public class GetParentCategoriesQueryHandler : IRequestHandler<GetParentCategoriesQueryRequest, BaseDataResponse<List<CategoryDto>>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public GetParentCategoriesQueryHandler(IMapper mapper, ICategoryReadRepository categoryReadRepository)
        {
            _mapper = mapper;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<BaseDataResponse<List<CategoryDto>>> Handle(GetParentCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var resultCategories = await _categoryReadRepository.GetWhere(x => x.DeletedDate == null && x.ParentId == 0, false).ToListAsync();
            var responseCategories = _mapper.Map<List<CategoryDto>>(resultCategories);

            return new SuccessDataResponse<List<CategoryDto>>(responseCategories);
        }
    }
}