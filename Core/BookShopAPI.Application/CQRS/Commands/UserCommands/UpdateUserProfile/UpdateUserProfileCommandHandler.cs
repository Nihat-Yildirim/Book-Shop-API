using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.UserCommands.UpdateUserProfile
{
    public class UpdateUserProfileCommandHandler : IRequestHandler<UpdateUserProfileCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        public UpdateUserProfileCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateUserProfileCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Id == request.Id);

            if (selectedUser == null)
                return new SuccesNoDataResponse();

            selectedUser.FirstName = request.Name;
            selectedUser.LastName = request.LastName;

            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}