using AutoMapper;
using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetAllDistrict
{
    public class GetAllDistrictQueryHandler : IRequestHandler<GetAllDistrictQueryRequest, BaseDataResponse<List<DistrictDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IDistrictReadRepository _districtReadRepository;

        public GetAllDistrictQueryHandler(IMapper mapper, IDistrictReadRepository districtReadRepository)
        {
            _mapper = mapper;
            _districtReadRepository = districtReadRepository;
        }

        public async Task<BaseDataResponse<List<DistrictDto>>> Handle(GetAllDistrictQueryRequest request, CancellationToken cancellationToken)
        {
            var districts = await _districtReadRepository.GetWhere(x => x.DeletedDate == null,false).ToListAsync();
            var response = _mapper.Map<List<DistrictDto>>(districts);

            return new SuccessDataResponse<List<DistrictDto>>(response);
        }
    }
}