using AutoMapper;
using BookShopAPI.Application.DTOs.ProvinceDTOs;
using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.ProvinceQueries.GetAllProvince
{
    public class GetAllProvinceQueryHandler : IRequestHandler<GetAllProvinceQueryRequest, BaseDataResponse<List<ProvinceDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IProvinceReadRepository _provinceReadRepository;

        public GetAllProvinceQueryHandler(IMapper mapper, IProvinceReadRepository provinceReadRepository)
        {
            _mapper = mapper;
            _provinceReadRepository = provinceReadRepository;
        }

        public async Task<BaseDataResponse<List<ProvinceDto>>> Handle(GetAllProvinceQueryRequest request, CancellationToken cancellationToken)
        {
            var provinces = await _provinceReadRepository.GetWhere(x => x.DeletedDate == null,false).ToListAsync();
            var response = _mapper.Map<List<ProvinceDto>>(provinces);

            return new SuccessDataResponse<List<ProvinceDto>>(response);
        }
    }
}