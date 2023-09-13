using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Tokens;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.RefreshTokenLogin
{
    public class RefreshTokenLoginQueryHandler : IRequestHandler<RefreshTokenLoginQueryRequest, BaseDataResponse<LoginResultDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IAccessTokenService _accessTokenService;
        private readonly IRefreshTokenService _refreshTokenService;
        private readonly IUserClaimReadRepository _userClaimReadRepository;

        public RefreshTokenLoginQueryHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IRefreshTokenService refreshTokenService, IUserClaimReadRepository userClaimReadRepository, IAccessTokenService accessTokenService)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _refreshTokenService = refreshTokenService;
            _userClaimReadRepository = userClaimReadRepository;
            _accessTokenService = accessTokenService;
        }

        public async Task<BaseDataResponse<LoginResultDto>> Handle(RefreshTokenLoginQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                                        .Include(x => x.RefreshToken)
                                        .SingleOrDefaultAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailDataResponse<LoginResultDto>();

            if (selectedUser.RefreshToken == null)
                return new FailDataResponse<LoginResultDto>();

            if (selectedUser.RefreshToken.Token != request.RefreshToken)
                return new FailDataResponse<LoginResultDto>();

            if (selectedUser.RefreshToken.Expires < DateTime.Now)
                return new FailDataResponse<LoginResultDto>();

            var userClaims = await _userClaimReadRepository.GetWhere(x => x.UserId == selectedUser.Id).Include(x => x.Claim).ToListAsync();
            var refreshToken = _refreshTokenService.CreateRefreshToken();
            var accessToken = _accessTokenService.CreateAccessToken(selectedUser, userClaims.Select(x => x.Claim).ToList());

            selectedUser.RefreshToken.Token = refreshToken.Token;
            selectedUser.RefreshToken.Expires = refreshToken.Expiration;
            await _unitOfWork.SaveChangesAsync();

            TokenDto token = new()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
            };

            LoginResultDto loginResult = new();
            loginResult.Token = token;
            loginResult.UserId = selectedUser.Id;
            loginResult.Authenticator = selectedUser.AuthenticatorType;

            return new SuccessDataResponse<LoginResultDto>(loginResult);
        }
    }
}