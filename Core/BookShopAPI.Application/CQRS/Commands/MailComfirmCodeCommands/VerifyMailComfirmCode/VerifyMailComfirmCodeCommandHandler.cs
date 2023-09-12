using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.VerifyMailComfirmCode
{
    public class VerifyMailComfirmCodeCommandHandler : IRequestHandler<VerifyMailComfirmCodeCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IUserReadRepository _userReadRepository;
        public VerifyMailComfirmCodeCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IMailService mailService)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _mailService = mailService;
        }

        public async Task<BaseResponse> Handle(VerifyMailComfirmCodeCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithMailComfirmCodeAsync(x => x.Email == request.Email);

            if (selectedUser == null)
                return new FailNoDataResponse();

            if (selectedUser.MailComfirmCode.ComfirmDuration < DateTime.Now)
            {
                selectedUser.MailComfirmCode.ComfirmCode = RandomNumberHelper.GenerateNumberToString(6);
                selectedUser.MailComfirmCode.ComfirmDuration = DateTime.Now.AddDays(1);
                selectedUser.MailComfirmCode.IsComfirm = false;

                Mail mail = new()
                {
                    ToEmail = selectedUser.Email,
                    ToFullName = selectedUser.FirstName + " " + selectedUser.LastName,
                    Subject = "Doğrulama Kodu",
                    HtmlBody = $"<h5>{selectedUser.MailComfirmCode.ComfirmCode}</h5>"
                };
                await _mailService.SendAsync(mail);
                await _unitOfWork.SaveChangesAsync();

                return new FailNoDataResponse();
            }

            if (selectedUser.MailComfirmCode.ComfirmCode != request.Code)
                return new FailNoDataResponse();

            selectedUser.MailComfirmCode.IsComfirm = true;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}