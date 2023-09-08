using BookShopAPI.Application.Repositories.BasketItemRepositories;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.DeleteBasketItem
{
    public class DeleteBasketItemCommandHandler : IRequestHandler<DeleteBasketItemCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBasketReadRepository _basketReadRepository;
        private readonly IBasketItemWriteRepository _basketItemWriteRepository;

        public DeleteBasketItemCommandHandler(IUnitOfWork unitOfWork, IBasketReadRepository basketReadRepository, IBasketItemWriteRepository basketItemWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _basketReadRepository = basketReadRepository;
            _basketItemWriteRepository = basketItemWriteRepository;
        }

        public async Task<BaseResponse> Handle(DeleteBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedBasket = await _basketReadRepository.Table.Include(x => x.BasketItems).SingleOrDefaultAsync(x => x.Id == request.BasketId && x.UserId == request.UserId && x.Visible == true);
            if (selectedBasket == null)
                return new FailNoDataResponse();

            var deletedBasketItem = selectedBasket?.BasketItems?.SingleOrDefault(x => x.Id == request.BasketItemId);
            if (deletedBasketItem == null)
                return new FailNoDataResponse();

            _basketItemWriteRepository.Remove(deletedBasketItem);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}