using BookShopAPI.Application.DTOs.BasketDTOs;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BasketQueries.GetBasketByUserId
{
    public class GetBasketByUserIdQueryHandler : IRequestHandler<GetBasketByUserIdQueryRequest, BaseDataResponse<BasketDto>>
    {
        private readonly IBasketReadRepository _basketReadRepository;

        public GetBasketByUserIdQueryHandler(IBasketReadRepository basketReadRepository)
        {
            _basketReadRepository = basketReadRepository;
        }

        public async Task<BaseDataResponse<BasketDto>> Handle(GetBasketByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseData = await _basketReadRepository.GetBasketDtoAsync(request.UserId);
            return new SuccessDataResponse<BasketDto>(responseData);
        }
    }
}