using BookShopAPI.Application.Helpers.Hashing;
using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.MailAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailAuthenticationCommands.AddMailAuthentication
{
    public class AddMailAuthenticaitonCommandHandler : IRequestHandler<AddMailAuthenticaitonCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IMailAuthenticationWriteRepository _mailAuthenticationWriteRepository;

        public AddMailAuthenticaitonCommandHandler(IUnitOfWork unitOfWork, IMailService mailService, IMailAuthenticationWriteRepository mailAuthenticationWriteRepository, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _mailService = mailService;
            _userReadRepository = userReadRepository;
            _mailAuthenticationWriteRepository = mailAuthenticationWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddMailAuthenticaitonCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Email && x.DeletedDate == null && x.AuthenticatorType == AuthenticatorType.None);
            if (selectedUser == null)
                return new FailNoDataResponse();

            bool isVerify = HashingHelper.VerifyPasswordHash(request.Password, selectedUser.PasswordHash, selectedUser.PasswordSalt);
            if(!isVerify)
                return new FailNoDataResponse();

            string activationCode = RandomNumberHelper.GenerateNumberToString(6);
            MailAuthentication mailAuthentication = new();
            mailAuthentication.ActivationKey = activationCode;
            mailAuthentication.IsVerified = false;
            mailAuthentication.ActivationDuration = DateTime.Now.AddHours(2);
            mailAuthentication.Id = selectedUser.Id;

            await _mailAuthenticationWriteRepository.AddAsync(mailAuthentication);
            await _unitOfWork.SaveChangesAsync();

            Mail mail = new()
            {
                Subject = "Doğrulama Kodu",
                ToEmail = selectedUser.Email,
                ToFullName = selectedUser.FirstName + " " + selectedUser.LastName,
                TextBody = "Lütfen aşağıda yer alan doğrulama kodunu ilgili alana yazınız",
                HtmlBody = $"<h5>{activationCode}</h5>",
            };

            await _mailService.SendAsync(mail);

            return new SuccesNoDataResponse();
        }
    }
}