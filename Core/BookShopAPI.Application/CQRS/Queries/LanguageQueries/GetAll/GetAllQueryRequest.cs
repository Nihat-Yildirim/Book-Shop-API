using BookShopAPI.Application.DTOs.LanguageDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.LanguageQueries.GetAll
{
    public class GetAllQueryRequest : IRequest<BaseDataResponse<List<LanguageDto>>>
    {
    }
}