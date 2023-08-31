using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Address.DeleteAddress
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public DeleteAddressCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(DeleteAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithAddress(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            var deletedAddress = selectedUser.Addresses.SingleOrDefault(x => x.Id == request.AddressId);

            if (deletedAddress == null)
                return new FailNoDataResponse();

            selectedUser.Addresses.Remove(deletedAddress);

            foreach(var address in selectedUser.Addresses)
            {
                address.Selected = true;
                break;
            }

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}