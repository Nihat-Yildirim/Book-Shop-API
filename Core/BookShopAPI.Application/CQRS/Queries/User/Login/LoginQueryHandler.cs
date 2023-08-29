using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.Helpers.Hashing;
using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Tokens;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.User.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQueryRequest, BaseDataResponse<ResultTokenDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccessTokenService _accessTokenService;
        private readonly IRefreshTokenService _refreshTokenService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserClaimReadRepository _userClaimReadRepository;
        public LoginQueryHandler(IAccessTokenService accessTokenService, IRefreshTokenService refreshTokenService, IUserReadRepository userReadRepository, IUserClaimReadRepository userClaimReadRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _accessTokenService = accessTokenService;
            _refreshTokenService = refreshTokenService;
            _userReadRepository = userReadRepository;
            _userClaimReadRepository = userClaimReadRepository;
        }

        public async Task<BaseDataResponse<ResultTokenDto>> Handle(LoginQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                                .Include(x => x.RefreshToken)
                                .Include(x => x.MailComfirmCode)
                                .SingleOrDefaultAsync(x => x.Email == request.Email);

            if (selectedUser == null)
                return new FailDataResponse<ResultTokenDto>();

            if (!selectedUser.MailComfirmCode.IsComfirm)
                return new FailDataResponse<ResultTokenDto>();

            if (selectedUser.DeletedDate != default)
                return new FailDataResponse<ResultTokenDto>();

            var isVerify = HashingHelper.VerifyPasswordHash(request.Password, selectedUser.PasswordHash, selectedUser.PasswordSalt);

            if (!isVerify)
                return new FailDataResponse<ResultTokenDto>();

            var userClaims = await _userClaimReadRepository.GetWhere(x => x.UserId == selectedUser.Id).Include(x => x.Claim).ToListAsync();
            var refreshToken = _refreshTokenService.CreateRefreshToken();
            var accessToken = _accessTokenService.CreateAccessToken(selectedUser,userClaims.Select(x => x.Claim).ToList());

            if (selectedUser.RefreshToken == null)
                selectedUser.RefreshToken = new()
                {
                    Token = refreshToken.Token,
                    Expires = refreshToken.Expiration,
                };

            if(selectedUser.RefreshToken != null)
            {
                selectedUser.RefreshToken.Token = refreshToken.Token;
                selectedUser.RefreshToken.Expires = refreshToken.Expiration;
            }

            await _unitOfWork.SaveChangesAsync();

            ResultTokenDto resultToken = new()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
            };

            return new SuccessDataResponse<ResultTokenDto>(resultToken);
        }
    }
}