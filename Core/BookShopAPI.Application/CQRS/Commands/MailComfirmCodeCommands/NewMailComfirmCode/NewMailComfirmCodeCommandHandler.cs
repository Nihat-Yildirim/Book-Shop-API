using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.MailComfirmCodeRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.NewMailComfirmCode
{
    public class NewMailComfirmCodeCommandHandler : IRequestHandler<NewMailComfirmCodeCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IMailComfirmCodeReadRepository _mailComfirmCodeReadRepository;

        public NewMailComfirmCodeCommandHandler(IUnitOfWork unitOfWork, IMailService mailService, IUserReadRepository userReadRepository, IMailComfirmCodeReadRepository mailComfirmCodeReadRepository)
        {
            _unitOfWork = unitOfWork;
            _mailService = mailService;
            _userReadRepository = userReadRepository;
            _mailComfirmCodeReadRepository = mailComfirmCodeReadRepository;
        }

        public async Task<BaseResponse> Handle(NewMailComfirmCodeCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Mail && x.DeletedDate == null , false);
            if (selectedUser == null)
                return new FailNoDataResponse();

            var selectedMailComfirmCode = await _mailComfirmCodeReadRepository.GetSingleAsync(x => x.IsComfirm == false && x.Id == selectedUser.Id);
            if(selectedMailComfirmCode == null)
                return new FailNoDataResponse();

            var comfirmCode = RandomNumberHelper.GenerateNumberToString(6);
            selectedMailComfirmCode.ComfirmDuration = DateTime.Now.AddDays(1);
            selectedMailComfirmCode.ComfirmCode = comfirmCode;
            await _unitOfWork.SaveChangesAsync();

            Mail mail = new()
            {
                ToEmail = selectedUser.Email,
                ToFullName = selectedUser.FirstName + " " + selectedUser.LastName,
                Subject = "Doğrulama Kodu",
                HtmlBody = $"<h2>{comfirmCode}</h2>"
            };

            await _mailService.SendAsync(mail);
            return new SuccesNoDataResponse();
        }
    }
}