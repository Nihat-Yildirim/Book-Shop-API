using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.DistrictCommands.AddDistrict
{
    public class AddDistrictCommandRequest : IRequest<BaseResponse>
    {
        public int ProvinceId { get; set; }
        public string? Name { get; set; }
    }
}