using AutoMapper;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Category.GetCategoryById
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, BaseDataResponse<CategoryDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public GetCategoryByIdQueryHandler(IMapper mapper, ICategoryReadRepository categoryReadRepository)
        {
            _mapper = mapper;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<BaseDataResponse<CategoryDto>> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedCategory = await _categoryReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == request.Id, false);
            var responseCategory = _mapper.Map<CategoryDto>(selectedCategory);

            return new SuccessDataResponse<CategoryDto>(responseCategory);
        }
    }
}