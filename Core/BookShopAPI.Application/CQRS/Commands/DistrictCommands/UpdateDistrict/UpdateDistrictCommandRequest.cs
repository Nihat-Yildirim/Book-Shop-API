using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.DistrictCommands.UpdateDistrict
{
    public class UpdateDistrictCommandRequest : IRequest<BaseResponse>
    {
        public int DistrictId { get; set; }
        public string? Name { get; set; }
    }
}