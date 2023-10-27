using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.AddNeighbourhood
{
    public class AddNeighbourhoodCommandHandler : IRequestHandler<AddNeighbourhoodCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;
        private readonly INeighbourhoodWriteRepository _neighbourhoodWriteRepository;

        public AddNeighbourhoodCommandHandler(IUnitOfWork unitOfWork, IDistrictReadRepository districtReadRepository, INeighbourhoodReadRepository neighbourhoodReadRepository, INeighbourhoodWriteRepository neighbourhoodWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _districtReadRepository = districtReadRepository;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
            _neighbourhoodWriteRepository = neighbourhoodWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddNeighbourhoodCommandRequest request, CancellationToken cancellationToken)
        {
            bool isDistrictExists = await _districtReadRepository.AnyAsync(x => x.Id == request.DistrictId && x.DeletedDate == null);
            if (!isDistrictExists)
                return new FailNoDataResponse();

            bool isNameExists = await _neighbourhoodReadRepository.AnyAsync(x => x.DistrictId == request.DistrictId && x.Name == request.Name);
            if(isNameExists)
                return new FailNoDataResponse();

            Neighbourhood addedNeighbourhood = new();
            addedNeighbourhood.DistrictId = request.DistrictId;
            addedNeighbourhood.Name = request.Name;

            await _neighbourhoodWriteRepository.AddAsync(addedNeighbourhood);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}