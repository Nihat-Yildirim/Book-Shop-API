using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.DistrictCommands.DeleteDistrict
{
    public class DeleteDistrictCommandHandler : IRequestHandler<DeleteDistrictCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistrictReadRepository _districtReadRepository;

        public DeleteDistrictCommandHandler(IUnitOfWork unitOfWork, IDistrictReadRepository districtReadRepository)
        {
            _unitOfWork = unitOfWork;
            _districtReadRepository = districtReadRepository;
        }

        public async Task<BaseResponse> Handle(DeleteDistrictCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedDistrict = await _districtReadRepository.GetSingleAsync(x => x.ProvinceId != 0 && x.Id == request.Id);
            if (selectedDistrict == null)
                return new FailNoDataResponse();

            selectedDistrict.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}