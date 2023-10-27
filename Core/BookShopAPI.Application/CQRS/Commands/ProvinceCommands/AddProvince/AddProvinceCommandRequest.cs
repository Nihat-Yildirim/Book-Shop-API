using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ProvinceCommands.AddProvince
{
    public class AddProvinceCommandRequest : IRequest<BaseResponse>
    {
        public string? Name { get; set; }
    }
}