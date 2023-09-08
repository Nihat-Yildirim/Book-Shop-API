using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.UpdateBasketItem
{
    public class UpdateBasketItemCommandHandler : IRequestHandler<UpdateBasketItemCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBasketReadRepository _basketReadRepository;
        public UpdateBasketItemCommandHandler(IBasketReadRepository basketReadRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _basketReadRepository = basketReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBasket = await _basketReadRepository.Table.Include(x => x.BasketItems).SingleOrDefaultAsync(x => x.Id == request.BasketId && x.UserId == request.UserId && x.Visible == true);
            if (selectedBasket == null)
                return new FailNoDataResponse();

            var updatedBasketItem =  selectedBasket?.BasketItems?.SingleOrDefault(x => x.Id == request.BasketItemId);
            if(updatedBasketItem == null)
                return new FailNoDataResponse();

            updatedBasketItem.Quantity = request.Quantity;
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}