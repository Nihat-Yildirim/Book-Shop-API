using AutoMapper;
using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetNeighbourhoodsByDistrictId
{
    public class GetNeighbourhoodsByDistrictIdQueryHandler : IRequestHandler<GetNeighbourhoodsByDistrictIdQueryRequest, BaseDataResponse<List<NeighbourhoodDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;

        public GetNeighbourhoodsByDistrictIdQueryHandler(IMapper mapper, INeighbourhoodReadRepository neighbourhoodReadRepository, IDistrictReadRepository districtReadRepository)
        {
            _mapper = mapper;
            _districtReadRepository = districtReadRepository;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
        }

        public async Task<BaseDataResponse<List<NeighbourhoodDto>>> Handle(GetNeighbourhoodsByDistrictIdQueryRequest request, CancellationToken cancellationToken)
        {
            bool isDistrictExists = await _districtReadRepository.AnyAsync(x => x.Id == request.DistrictId && x.DeletedDate == null);
            if(!isDistrictExists)
                return new FailDataResponse<List<NeighbourhoodDto>>();

            var neighbourhoods = await _neighbourhoodReadRepository.GetWhere(x => x.DeletedDate == null && x.DistrictId == request.DistrictId, false).ToListAsync();
            var response = _mapper.Map<List<NeighbourhoodDto>>(neighbourhoods);

            return new SuccessDataResponse<List<NeighbourhoodDto>>(response);
        }
    }
}