using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IProvinceReadRepository _provinceReadRepository;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly INeighbourhoodReadRepository _neighbourhoodReadRepository;

        public UpdateAddressCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IProvinceReadRepository provinceReadRepository, IDistrictReadRepository districtReadRepository, INeighbourhoodReadRepository neighbourhoodReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _provinceReadRepository = provinceReadRepository;
            _districtReadRepository = districtReadRepository;
            _neighbourhoodReadRepository = neighbourhoodReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithAddressAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            var updatedAddress = selectedUser.Addresses.SingleOrDefault(x => x.Id == request.AddressId);
            if (updatedAddress == null)
                return new FailNoDataResponse();

            bool isProvinceExists = await _provinceReadRepository.AnyAsync(x => x.Id == request.ProvinceId && x.DeletedDate == null);
            if (!isProvinceExists)
                return new FailNoDataResponse();

            bool isDistrictExists = await _districtReadRepository.AnyAsync(x => x.Id == request.DistrictId && x.DeletedDate == null && x.ProvinceId == request.ProvinceId);
            if (!isDistrictExists)
                return new FailNoDataResponse();

            bool isNeighbourhoodExists = await _neighbourhoodReadRepository.AnyAsync(x => x.Id == request.NeighbourhoodId && x.DeletedDate == null && x.DistrictId == request.DistrictId);
            if (!isNeighbourhoodExists)
                return new FailNoDataResponse();

            if (updatedAddress.Selected != request.Selected && updatedAddress.Selected == true)
                foreach (var address in selectedUser.Addresses.ToList().OrderByDescending(x => x.UpdatedDate))
                    if (address.Id != updatedAddress.Id && address.DeletedDate != null)
                    {
                        address.Selected = true;
                        break;
                    }

            updatedAddress.PhoneNumber = request.PhoneNumber;
            updatedAddress.AddressTitle = request.AddressTitle;
            updatedAddress.Description = request.Description;
            updatedAddress.ProvinceId = request.ProvinceId;
            updatedAddress.DistrictId = request.DistrictId;
            updatedAddress.NeighbourhoodId = request.NeighbourhoodId;
            updatedAddress.OpenAddress = request.OpenAddress;
            updatedAddress.Selected = request.Selected;

            if (selectedUser.Addresses.Count == 1)
                updatedAddress.Selected = true;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}