using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.UpdateNeighbourhood
{
    public class UpdateNeighbourhoodCommandHandler : IRequestHandler<UpdateNeighbourhoodCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;

        public UpdateNeighbourhoodCommandHandler(IUnitOfWork unitOfWork, INeighbourhoodReadRepository neighbourhoodReadRepository)
        {
            _unitOfWork = unitOfWork;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateNeighbourhoodCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedNeighbourhood = await _neighbourhoodReadRepository.GetSingleAsync(x => x.DeletedDate == null && x.Id == request.Id);
            if (selectedNeighbourhood == null)
                return new FailNoDataResponse();

            bool isNameExists = await _neighbourhoodReadRepository.AnyAsync(x => x.DistrictId == selectedNeighbourhood.DistrictId && x.Name == request.Name);
            if(isNameExists)
                return new FailNoDataResponse();

            selectedNeighbourhood.Name = request.Name;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}