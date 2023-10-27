using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.DistrictCommands.DeleteDistrict
{
    public class DeleteDistrictCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}