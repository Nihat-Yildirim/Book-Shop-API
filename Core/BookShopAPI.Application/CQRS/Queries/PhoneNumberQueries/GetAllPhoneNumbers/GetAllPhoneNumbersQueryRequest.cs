using BookShopAPI.Application.DTOs.PhoneNumberDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.PhoneNumberQueries.GetAllPhoneNumbers
{
    public class GetAllPhoneNumbersQueryRequest : IRequest<BaseDataResponse<List<PhoneNumberForAdminDto>>>
    {
    }
}