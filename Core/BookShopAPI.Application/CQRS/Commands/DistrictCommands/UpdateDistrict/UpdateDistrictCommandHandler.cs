using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.DistrictCommands.UpdateDistrict
{
    public class UpdateDistrictCommandHandler : IRequestHandler<UpdateDistrictCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistrictReadRepository _districtReadRepository;

        public UpdateDistrictCommandHandler(IUnitOfWork unitOfWork, IDistrictReadRepository districtReadRepository)
        {
            _unitOfWork = unitOfWork;
            _districtReadRepository = districtReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateDistrictCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedDistrict = await _districtReadRepository.GetSingleAsync(x => x.Id == request.DistrictId && x.ProvinceId != 0);
            if (selectedDistrict == null)
                return new FailNoDataResponse();

            bool isNameExists = await _districtReadRepository.AnyAsync(x => x.ProvinceId == selectedDistrict.ProvinceId && x.Name == request.Name);
            if (isNameExists)
                return new FailNoDataResponse();

            selectedDistrict.Name = request.Name;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}