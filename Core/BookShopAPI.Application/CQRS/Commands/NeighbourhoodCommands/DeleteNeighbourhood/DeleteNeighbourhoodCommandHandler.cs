using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.NeighbourhoodCommands.DeleteNeighbourhood
{
    public class DeleteNeighbourhoodCommandHandler : IRequestHandler<DeleteNeighbourhoodCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;

        public DeleteNeighbourhoodCommandHandler(IUnitOfWork unitOfWork, INeighbourhoodReadRepository neighbourhoodReadRepository)
        {
            _unitOfWork = unitOfWork;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
        }

        public async Task<BaseResponse> Handle(DeleteNeighbourhoodCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedNeighbourhood = await _neighbourhoodReadRepository.GetSingleAsync(x => x.Id == request.Id);
            if (selectedNeighbourhood == null)
                return new FailNoDataResponse();

            selectedNeighbourhood.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}