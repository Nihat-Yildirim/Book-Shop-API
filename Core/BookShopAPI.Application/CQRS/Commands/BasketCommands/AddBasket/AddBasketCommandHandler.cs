using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasket
{
    public class AddBasketCommandHandler : IRequestHandler<AddBasketCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IBasketWriteRepository _basketWriteRepository;
        public AddBasketCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IBasketWriteRepository basketWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _basketWriteRepository = basketWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddBasketCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                            .Include(x => x.Baskets)
                            .Include(x => x.UserClaim)
                            .SingleOrDefaultAsync(x => x.Id == request.UserId);

            if (selectedUser == null)
                return new FailNoDataResponse();

            if(selectedUser?.UserClaim?.ClaimId != (int)Claims.Customer)
                return new FailNoDataResponse();

            foreach(var basket in selectedUser.Baskets)
                if(basket.Visible == true)
                    return new FailNoDataResponse();

            Basket addedBasket = new();
            addedBasket.UserId = selectedUser.Id;
            addedBasket.Visible = true;

            await _basketWriteRepository.AddAsync(addedBasket);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}