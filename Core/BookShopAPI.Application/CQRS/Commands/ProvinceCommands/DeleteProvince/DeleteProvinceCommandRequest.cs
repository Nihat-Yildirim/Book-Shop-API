using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ProvinceCommands.DeleteProvince
{
    public class DeleteProvinceCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}