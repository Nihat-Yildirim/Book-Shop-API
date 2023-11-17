using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Application.Repositories.BasketItemRepositories;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Application.Repositories.OrderRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.OrderCommands.AddOrder
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IBasketReadRepository _basketReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IBasketWriteRepository _basketWriteRepository;
        private readonly IAddressReadRepository _addressReadRepository;
        private readonly IBasketItemWriteRepository _basketItemWriteRepository;

        public AddOrderCommandHandler(IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IBasketReadRepository basketReadRepository, IOrderWriteRepository orderWriteRepository, IBasketWriteRepository basketWriteRepository, IAddressReadRepository addressReadRepository, IBasketItemWriteRepository basketItemWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _basketReadRepository = basketReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _basketWriteRepository = basketWriteRepository;
            _addressReadRepository = addressReadRepository;
            _basketItemWriteRepository = basketItemWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var anyUser = await _userReadRepository.AnyAsync(x => x.Id == request.UserId && x.DeletedDate == null);
            if (!anyUser)
                return new FailNoDataResponse();

            var anyAddress = await _addressReadRepository.AnyAsync(x => x.Id == request.AddressId && x.DeletedDate == null && x.UserId == request.UserId);
            if(!anyAddress)
                return new FailNoDataResponse();

            var selectedBasket = await _basketReadRepository.Table
                                .Include(x => x.BasketItems)
                                .ThenInclude(x => x.Book)
                                .SingleOrDefaultAsync(x => x.Id == request.BasketId && x.Visible == true && x.UserId == request.UserId);
            
            if(selectedBasket == null)
                return new FailNoDataResponse();

            float totalPayment = 0;
            selectedBasket.BasketItems?.Where(x => x.Selected == true).ToList().ForEach(x => { totalPayment = totalPayment + x.Quantity * x.Book.Price; });
            
            if(totalPayment != request.TotalPayment)
                return new FailNoDataResponse();

            var notSelectedBasketItems = selectedBasket.BasketItems.Where(x => x.Selected == false).ToList();
            _basketItemWriteRepository.RemoveRange(notSelectedBasketItems);

            Order addedOrder = new(){
                BasketId = selectedBasket.Id,
                UserId = request.UserId,
                AddressId = request.AddressId,
                PhoneNumberId = request.PhoneId,
                TotalPayment = totalPayment,
                Pay = true,
                PaymentDate = DateTime.Now,
            };

            Basket addedBasket = new(){
                UserId = request.UserId,
                Visible = true,
            };

            selectedBasket?.BasketItems?.ToList().ForEach(basketItem =>
            {
                if (basketItem.Book != null)
                    basketItem.Book.Stock = basketItem.Book.Stock + basketItem.Quantity;
            });

            selectedBasket.Visible = false;
            await _basketWriteRepository.AddAsync(addedBasket);
            await _orderWriteRepository.AddAsync(addedOrder);
            await _unitOfWork.SaveChangesAsync();

            notSelectedBasketItems.ForEach(x => x.BasketId = addedBasket.Id);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}