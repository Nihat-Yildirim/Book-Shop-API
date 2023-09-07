using BookShopAPI.Application.DTOs.PhoneNumberDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.PhoneNumberQueries.GetPhoneNumbersByUserId
{
    public class GetPhoneNumbersByUserIdQueryRequest : IRequest<BaseDataResponse<List<PhoneNumberDto>>>
    {
        public int UserId { get; set; }
    }
}