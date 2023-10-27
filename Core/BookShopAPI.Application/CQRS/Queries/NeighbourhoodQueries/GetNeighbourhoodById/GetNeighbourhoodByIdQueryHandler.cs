using AutoMapper;
using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.NeighbourhoodQueries.GetNeighbourhoodById
{
    public class GetNeighbourhoodByIdQueryHandler : IRequestHandler<GetNeighbourhoodByIdQueryRequest, BaseDataResponse<NeighbourhoodDto>>
    {
        private readonly IMapper _mapper;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;

        public GetNeighbourhoodByIdQueryHandler(IMapper mapper, INeighbourhoodReadRepository neighbourhoodReadRepository)
        {
            _mapper = mapper;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
        }

        public async Task<BaseDataResponse<NeighbourhoodDto>> Handle(GetNeighbourhoodByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedNeighbourhood = await _neighbourhoodReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == request.Id, false);
            var response = _mapper.Map<NeighbourhoodDto>(selectedNeighbourhood);

            return new SuccessDataResponse<NeighbourhoodDto>(response);
        }
    }
}