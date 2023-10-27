using AutoMapper;
using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetDistrictsByProvinceId
{
    public class GetDistrictsByProvinceIdQueryHandler : IRequestHandler<GetDistrictsByProvinceIdQueryRequest, BaseDataResponse<List<DistrictDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly IProvinceReadRepository _provinceReadRepository;

        public GetDistrictsByProvinceIdQueryHandler(IMapper mapper, IDistrictReadRepository districtReadRepository, IProvinceReadRepository provinceReadRepository)
        {
            _mapper = mapper;
            _districtReadRepository = districtReadRepository;
            _provinceReadRepository = provinceReadRepository;
        }

        public async Task<BaseDataResponse<List<DistrictDto>>> Handle(GetDistrictsByProvinceIdQueryRequest request, CancellationToken cancellationToken)
        {
            bool provinceExists = await _provinceReadRepository.AnyAsync(x => x.DeletedDate == null && x.Id == request.ProvinceId);
            if(!provinceExists)
                return new FailDataResponse<List<DistrictDto>>();

            var districts = await _districtReadRepository.GetWhere(x => x.DeletedDate == null, false).ToListAsync();
            var response = _mapper.Map<List<DistrictDto>>(districts);

            return new SuccessDataResponse<List<DistrictDto>>(response);
        }
    }
}