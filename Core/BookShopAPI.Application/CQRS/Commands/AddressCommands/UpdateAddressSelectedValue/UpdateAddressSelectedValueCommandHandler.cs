using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddressSelectedValue
{
    public class UpdateAddressSelectedValueCommandHandler : IRequestHandler<UpdateAddressSelectedValueCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAddressReadRepository _addressReadRepository;

        public UpdateAddressSelectedValueCommandHandler(IUnitOfWork unitOfWork, IAddressReadRepository addressReadRepository)
        {
            _unitOfWork = unitOfWork;
            _addressReadRepository = addressReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateAddressSelectedValueCommandRequest request, CancellationToken cancellationToken)
        {
            var addresses = await _addressReadRepository.GetWhere(x => x.DeletedDate == null && x.UserId == request.UserId).ToListAsync();
            if (addresses.Count < 2)
                return new FailNoDataResponse();

            var selectedAddress = addresses.SingleOrDefault(x => x.Selected == true);
            var updatedAddress = addresses.SingleOrDefault(x => x.Id == request.AddressId);

            if(selectedAddress != null || updatedAddress != null)
                return new FailNoDataResponse();

            if (selectedAddress.Id == updatedAddress.Id)
                return new SuccesNoDataResponse();

            selectedAddress.Selected = false;
            updatedAddress.Selected = true;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}