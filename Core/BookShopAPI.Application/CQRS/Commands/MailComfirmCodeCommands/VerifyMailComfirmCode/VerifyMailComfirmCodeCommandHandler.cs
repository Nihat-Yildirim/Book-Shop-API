using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Tokens;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.MailComfirmCodeCommands.VerifyMailComfirmCode
{
    public class VerifyMailComfirmCodeCommandHandler : IRequestHandler<VerifyMailComfirmCodeCommandRequest, BaseDataResponse<LoginResultDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IAccessTokenService _accessTokenService;
        private readonly IRefreshTokenService _refreshTokenService;
        private readonly IUserClaimReadRepository _userClaimReadRepository;
        public VerifyMailComfirmCodeCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IMailService mailService, IAccessTokenService accessTokenService, IRefreshTokenService refreshTokenService, IUserClaimReadRepository userClaimReadRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _mailService = mailService;
            _accessTokenService = accessTokenService;
            _refreshTokenService = refreshTokenService;
            _userClaimReadRepository = userClaimReadRepository;
        }

        public async Task<BaseDataResponse<LoginResultDto>> Handle(VerifyMailComfirmCodeCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetUserWithMailComfirmCodeAsync(x => x.Email == request.Email);
            if (selectedUser == null)
                return new FailDataResponse<LoginResultDto>();

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

                return new FailDataResponse<LoginResultDto>();
            }

            if (selectedUser.MailComfirmCode.ComfirmCode != request.Code)
                return new FailDataResponse<LoginResultDto>();

            var userClaims = await _userClaimReadRepository.Table.Include(x => x.Claim).Where(x => x.UserId == selectedUser.Id).ToListAsync();
            if (userClaims == null)
                return new FailDataResponse<LoginResultDto>();

            var accessToken = _accessTokenService.CreateAccessToken(selectedUser,userClaims.Select(x => x.Claim).ToList());
            var resultRefrestoken = _refreshTokenService.CreateRefreshToken();
            RefreshToken refreshToken = new()
            {
                CreatedDate = DateTime.Now,
                Expires = resultRefrestoken.Expiration,
                Token = resultRefrestoken.Token,
                Id = selectedUser.Id,
            };
            selectedUser.RefreshToken = refreshToken;
            selectedUser.MailComfirmCode.IsComfirm = true;
            await _unitOfWork.SaveChangesAsync();

            TokenDto token = new()
            {
               AccessToken = accessToken,
               RefreshToken = resultRefrestoken
            };

            LoginResultDto loginResultDto = new()
            {
                Authenticator = AuthenticatorType.None,
                Token = token,
                UserId = selectedUser.Id
            };
            return new SuccessDataResponse<LoginResultDto>(loginResultDto);
        }
    }
}