using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.UserClaim.UpdateUserClaim
{
    public class UpdateUserClaimCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public Claims Claim { get; set; }
    }
}