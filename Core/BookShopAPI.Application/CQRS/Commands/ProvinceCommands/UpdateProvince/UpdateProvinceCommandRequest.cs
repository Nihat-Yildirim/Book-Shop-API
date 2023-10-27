using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ProvinceCommands.UpdateProvince
{
    public class UpdateProvinceCommandRequest : IRequest<BaseResponse>
    {
        public int ProvinceId { get; set; }
        public string? Name { get; set; }
    }
}