using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.UpdatePhoneNumber
{
    public class UpdatePhoneNumberCommandHandler : IRequestHandler<UpdatePhoneNumberCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        public UpdatePhoneNumberCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdatePhoneNumberCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithPhoneNumberAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            var updatedPhoneNumber = selectedUser.PhoneNumbers.SingleOrDefault(x => x.Id == request.PhoneId);

            if(updatedPhoneNumber == null)
                return new FailNoDataResponse();

            if (updatedPhoneNumber.Selected != request.Selected && updatedPhoneNumber.Selected == true)
                foreach (var address in selectedUser.PhoneNumbers.ToList().OrderByDescending(x => x.UpdatedDate))
                    if (address.Id != updatedPhoneNumber.Id && address.DeletedDate != null)
                    {
                        address.Selected = true;
                        break;
                    }

            updatedPhoneNumber.PhoneNumber = request.PhoneNumber;
            updatedPhoneNumber.PhoneTitle = request.PhoneTitle; 
            updatedPhoneNumber.Selected = request.Selected;

            if (selectedUser.PhoneNumbers.Count == 1)
                updatedPhoneNumber.Selected = true;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}