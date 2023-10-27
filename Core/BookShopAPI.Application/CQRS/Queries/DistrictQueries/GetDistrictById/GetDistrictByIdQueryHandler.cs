using AutoMapper;
using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.DistrictQueries.GetDistrictById
{
    public class GetDistrictByIdQueryHandler : IRequestHandler<GetDistrictByIdQueryRequest, BaseDataResponse<DistrictDto>>
    {
        private readonly IMapper _mapper;
        private readonly IDistrictReadRepository _districtReadRepository;

        public GetDistrictByIdQueryHandler(IMapper mapper, IDistrictReadRepository districtReadRepository)
        {
            _mapper = mapper;
            _districtReadRepository = districtReadRepository;
        }

        public async Task<BaseDataResponse<DistrictDto>> Handle(GetDistrictByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedDistrict = await _districtReadRepository.GetSingleAsync(x => x.DeletedDate == null&& x.Id == request.Id,false);
            var response = _mapper.Map<DistrictDto>(selectedDistrict);

            return new SuccessDataResponse<DistrictDto>(response);
        }
    }
}