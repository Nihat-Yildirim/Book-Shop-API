using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.GetUserProfile
{
    public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQueryRequest, BaseDataResponse<UserProfileDto>>
    {
        private readonly IUserReadRepository _userReadRepository;

        public GetUserProfileQueryHandler(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseDataResponse<UserProfileDto>> Handle(GetUserProfileQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                                    .Include(x => x.Baskets)
                                    .Include(x => x.File)
                                    .SingleOrDefaultAsync(x => x.Id == request.UserId && x.DeletedDate == null);

            if(selectedUser == null) 
                return new FailDataResponse<UserProfileDto>();

            UserProfileDto userProfile = new()
            {
                FirstName = selectedUser.FirstName,
                LastName = selectedUser.LastName,
                AuthenticatorType = selectedUser.AuthenticatorType,
                Email = selectedUser.Email,
            };

            if (selectedUser.Baskets.Count == 0 || selectedUser.Baskets.SingleOrDefault(x => x.Visible == true) == null)
                userProfile.BasketId = 0;
            else
                userProfile.BasketId = selectedUser.Baskets.SingleOrDefault(x => x.Visible == true).Id;

            if (selectedUser.File != null)
                userProfile.PictureUrl = FileUrlHelper.Generate(selectedUser.File.FilePath);

            return new SuccessDataResponse<UserProfileDto>(userProfile);
        }
    }
}