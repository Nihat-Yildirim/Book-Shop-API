using AutoMapper;
using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetAllNeighbourhood
{
    public class GetAllNeighbourhoodQueryHandler : IRequestHandler<GetAllNeighbourhoodQueryRequest, BaseDataResponse<List<NeighbourhoodDto>>>
    {
        private readonly IMapper _mapper;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;

        public GetAllNeighbourhoodQueryHandler(IMapper mapper, INeighbourhoodReadRepository neighbourhoodReadRepository)
        {
            _mapper = mapper;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
        }

        public async Task<BaseDataResponse<List<NeighbourhoodDto>>> Handle(GetAllNeighbourhoodQueryRequest request, CancellationToken cancellationToken)
        {
            var neighbourhoods = await _neighbourhoodReadRepository.GetWhere(x => x.DeletedDate == null, false).ToListAsync();
            var response = _mapper.Map<List<NeighbourhoodDto>>(neighbourhoods);

            return new SuccessDataResponse<List<NeighbourhoodDto>>(response);
        }
    }
}