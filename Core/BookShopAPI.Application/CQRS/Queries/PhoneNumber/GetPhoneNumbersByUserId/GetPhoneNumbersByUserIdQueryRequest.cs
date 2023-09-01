using BookShopAPI.Application.DTOs.PhoneNumberDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.PhoneNumber.GetPhoneNumbersByUserId
{
    public class GetPhoneNumbersByUserIdQueryRequest : IRequest<BaseDataResponse<List<PhoneNumberDto>>>
    {
        public int UserId { get; set; }
    }
}