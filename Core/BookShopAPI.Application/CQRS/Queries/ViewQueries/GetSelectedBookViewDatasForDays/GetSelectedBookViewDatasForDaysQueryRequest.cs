using BookShopAPI.Application.DTOs.ViewDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.ViewQueries.GetSelectedBookViewDatasForDays
{
    public class GetSelectedBookViewDatasForDaysQueryRequest : IRequest<BaseDataResponse<List<ViewCountForDaysDto>>>
    {
        public int BookId { get; set; }
    }
}