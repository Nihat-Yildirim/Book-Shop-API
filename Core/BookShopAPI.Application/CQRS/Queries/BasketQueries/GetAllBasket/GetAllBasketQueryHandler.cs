using BookShopAPI.Application.DTOs.BasketDTOs;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BasketQueries.GetAllBasket
{
    public class GetAllBasketQueryHandler : IRequestHandler<GetAllBasketQueryRequest, BaseDataResponse<List<BasketForAdminDto>>>
    {
        private readonly IBasketReadRepository _basketReadRepository;

        public GetAllBasketQueryHandler(IBasketReadRepository basketReadRepository)
        {
            _basketReadRepository = basketReadRepository;
        }

        public async Task<BaseDataResponse<List<BasketForAdminDto>>> Handle(GetAllBasketQueryRequest request, CancellationToken cancellationToken)
        {
            var responseData = await _basketReadRepository.GetBasketForAdminDtosAsync();
            return new SuccessDataResponse<List<BasketForAdminDto>>(responseData);
        }
    }
}