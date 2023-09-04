using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PhoneNumber.DeletePhoneNumber
{
    public class DeletePhoneNumberCommandHandler : IRequestHandler<DeletePhoneNumberCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;

        public DeletePhoneNumberCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(DeletePhoneNumberCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithPhoneNumberAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            var deletedPhoneNumber = selectedUser.PhoneNumbers.SingleOrDefault(x => x.Id == request.PhoneId);

            if (deletedPhoneNumber == null)
                return new FailNoDataResponse();

            selectedUser.PhoneNumbers.Remove(deletedPhoneNumber);

            foreach (var phoneNumber in selectedUser.PhoneNumbers.ToList().OrderByDescending(x => x.UpdatedDate))
            {
                phoneNumber.Selected = true;
                break;
            }

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}