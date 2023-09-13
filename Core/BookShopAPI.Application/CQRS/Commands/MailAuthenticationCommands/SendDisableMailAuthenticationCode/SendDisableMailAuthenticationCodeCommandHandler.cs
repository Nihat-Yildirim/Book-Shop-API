using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.MailAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.SendDisableMailAuthenticationCode
{
    public class SendDisableMailAuthenticationCodeCommandHandler : IRequestHandler<SendDisableMailAuthenticationCodeCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IMailAuthenticationReadRepository _mailAuthenticationReadRepository;

        public SendDisableMailAuthenticationCodeCommandHandler(IUnitOfWork unitOfWork, IMailService mailService, IUserReadRepository userReadRepository, IMailAuthenticationReadRepository mailAuthenticationReadRepository)
        {
            _unitOfWork = unitOfWork;
            _mailService = mailService;
            _userReadRepository = userReadRepository;
            _mailAuthenticationReadRepository = mailAuthenticationReadRepository;
        }

        public async Task<BaseResponse> Handle(SendDisableMailAuthenticationCodeCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Id == request.UserId && x.AuthenticatorType == AuthenticatorType.Email && x.DeletedDate == null);
            if (selectedUser == null)
                return new FailNoDataResponse();

            var selectedMailAuthentication = await _mailAuthenticationReadRepository.GetByIdAsync(selectedUser.Id);
            if(selectedMailAuthentication == null)
                return new FailNoDataResponse();

            string code = RandomNumberHelper.GenerateNumberToString(6);
            selectedMailAuthentication.ActivationKey = code;
            selectedMailAuthentication.ActivationDuration = DateTime.Now.AddHours(2);
            selectedMailAuthentication.IsVerified = false;
            await _unitOfWork.SaveChangesAsync();

            Mail mail = new()
            {
                HtmlBody = $"<h5>{code}</h5>",
                Subject = "İptal Kodu",
                TextBody = "Lütfen aşağıdaki kodu ilgili alana yazınız",
                ToEmail = selectedUser.Email,
                ToFullName = selectedUser.FirstName + " " + selectedUser.LastName,
            };
            await _mailService.SendAsync(mail);

            return new SuccesNoDataResponse();
        }
    }
}