using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailComfirmCode.VerifyMailComfirmCode
{
    public class VerifyMailComfirmCodeCommandHandler : IRequestHandler<VerifyMailComfirmCodeCommandRequest, BaseResponse>
    {
        private IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        public VerifyMailComfirmCodeCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseResponse> Handle(VerifyMailComfirmCodeCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithMailComfirmCodeAsync(x => x.Email == request.Email);

            if (selectedUser == null)
                return new FailNoDataResponse();

            if (selectedUser.MailComfirmCode.ComfirmDuration < DateTime.Now)
                return new FailNoDataResponse();

            if (selectedUser.MailComfirmCode.ComfirmCode != request.Code)
                return new FailNoDataResponse();

            selectedUser.MailComfirmCode.IsComfirm = true;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}