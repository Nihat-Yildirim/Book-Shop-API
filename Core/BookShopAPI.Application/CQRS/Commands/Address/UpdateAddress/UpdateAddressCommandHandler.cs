using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Address.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public UpdateAddressCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithAddress(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            var updatedAddress = selectedUser.Addresses.SingleOrDefault(x => x.Id == request.AddressId);

            if (updatedAddress == null)
                return new FailNoDataResponse();

            if (updatedAddress.Selected != request.Selected && updatedAddress.Selected == true)
                foreach (var address in selectedUser.Addresses)
                    if (address.Id != updatedAddress.Id)
                    {
                        address.Selected = true;
                        break;
                    }

            updatedAddress.AddressTitle = request.AddressTitle;
            updatedAddress.Description = request.Description;
            updatedAddress.Province = request.Province;
            updatedAddress.District = request.District;
            updatedAddress.Neighbourhood = request.Neighbourhood;
            updatedAddress.OpenAddress = request.OpenAddress;
            updatedAddress.Selected = request.Selected;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}