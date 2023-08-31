using AutoMapper;
using BookShopAPI.Application.Helpers.Hashing;
using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using UserEntity = BookShopAPI.Domain.Entities.User;

namespace BookShopAPI.Application.CQRS.Commands.User.CustomerRegister
{
    public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;

        public UserRegisterCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IMailService mailService, IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _mailService = mailService;
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }

        public async Task<BaseResponse> Handle(UserRegisterCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithMailComfirmCode(x => x.Email == request.Email);

            if (selectedUser != null)
                return new FailNoDataResponse();

            if(selectedUser != null && selectedUser.MailComfirmCode.IsComfirm == false)
            {

                if(selectedUser.MailComfirmCode.ComfirmDuration < DateTime.Now)
                {
                    _userWriteRepository.Remove(selectedUser);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    return new FailNoDataResponse();
                }
            }

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

            string comfirmCode = RandomNumberHelper.GenerateNumberToString(6);
            var addedUser = _mapper.Map<UserEntity>(request);
            addedUser.PasswordHash = passwordHash;
            addedUser.PasswordSalt = passwordSalt;
            addedUser.AuthenticatorType = (int)AuthenticatorType.None;

            addedUser.UserClaim = new()
            {
                ClaimId = (int)Claims.Customer
            };

            addedUser.MailComfirmCode = new()
            {
                ComfirmCode = comfirmCode,
                ComfirmDuration = DateTime.Now.AddDays(1),
                IsComfirm = false,
            };

            await _userWriteRepository.AddAsync(addedUser);
            await _unitOfWork.SaveChangesAsync();

            Mail mail = new()
            {
                ToEmail = request.Email,
                ToFullName = request.FirstName + " " + request.LastName,
                Subject ="Doğrulama Kodu",
                HtmlBody = $"<h5>{comfirmCode}</h5>"
            };
            
            await _mailService.SendAsync(mail);
            return new SuccesNoDataResponse();
        }
    }
}