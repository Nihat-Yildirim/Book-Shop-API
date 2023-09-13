using BookShopAPI.Application.Repositories.MailAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.DisableMailAuthentication
{
    public class DisableMailAuthenticationCommandHandler : IRequestHandler<DisableMailAuthenticationCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IMailAuthenticationReadRepository _mailAuthenticationReadRepository;
        private readonly IMailAuthenticationWriteRepository _mailAuthenticationWriteRepository;

        public DisableMailAuthenticationCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IMailAuthenticationReadRepository mailAuthenticationReadRepository, IMailAuthenticationWriteRepository mailAuthenticationWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _mailAuthenticationReadRepository = mailAuthenticationReadRepository;
            _mailAuthenticationWriteRepository = mailAuthenticationWriteRepository;
        }

        public async Task<BaseResponse> Handle(DisableMailAuthenticationCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Email && x.DeletedDate == null && x.AuthenticatorType == AuthenticatorType.Email);
            if (selectedUser == null)
                return new FailNoDataResponse();

            var selectedMailAuthentication = await _mailAuthenticationReadRepository.GetSingleAsync(x => x.Id == selectedUser.Id && x.ActivationDuration > DateTime.Now);
            if (selectedMailAuthentication == null)
                return new FailNoDataResponse();

            if (selectedMailAuthentication.ActivationKey != request.ActivationCode)
                return new FailNoDataResponse();

            selectedUser.AuthenticatorType = AuthenticatorType.None;
            _mailAuthenticationWriteRepository.Remove(selectedMailAuthentication);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}