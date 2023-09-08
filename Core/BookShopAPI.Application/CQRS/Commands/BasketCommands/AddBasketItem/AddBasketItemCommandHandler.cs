using AutoMapper;
using BookShopAPI.Application.Repositories.BasketItemRepositories;
using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasketItem
{
    public class AddBasketItemCommandHandler : IRequestHandler<AddBasketItemCommandRequest, BaseResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IBasketReadRepository _basketReadRepository;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IBasketItemReadRepository _basketItemReadRepository;
        private readonly IBasketItemWriteRepository _basketItemWriteRepository;

        public AddBasketItemCommandHandler(IBasketReadRepository basketReadRepository, IUnitOfWork unitOfWork, IUserReadRepository userReadRepository, IBookReadRepository bookReadRepository, IMapper mapper, IBasketItemWriteRepository basketItemWriteRepository, IBasketItemReadRepository basketItemReadRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userReadRepository = userReadRepository;
            _bookReadRepository = bookReadRepository;
            _basketReadRepository = basketReadRepository;
            _basketItemWriteRepository = basketItemWriteRepository;
            _basketItemReadRepository = basketItemReadRepository;
        }

        public async Task<BaseResponse> Handle(AddBasketItemCommandRequest request, CancellationToken cancellationToken)
        {
            bool anyUser = await _userReadRepository.AnyAsync(x => x.Id == request.UserId && x.UserClaim.ClaimId == (int)Claims.Customer && x.DeletedDate == null);
            if (!anyUser)
                return new FailNoDataResponse();

            bool anyBasket = await _basketReadRepository.AnyAsync(x => x.Id == request.BasketId && x.Visible == true);
            if(!anyBasket)
                return new FailNoDataResponse();

            var selectedBook = await _bookReadRepository.GetSingleAsync(x => x.Id == request.BookId && x.DeletedDate == null);
            if(selectedBook == null)
                return new FailNoDataResponse();

            if(selectedBook.Stock < request.Quantity)
                return new FailNoDataResponse();

            var basketItems = await _basketItemReadRepository.GetWhere(x => x.BasketId == request.BasketId).ToListAsync();
            
            foreach (var basketItem in basketItems)
                if(basketItem.BookId == request.BookId)
                    return new FailNoDataResponse();

            var addedBasketItem = _mapper.Map<BasketItem>(request);
            await _basketItemWriteRepository.AddAsync(addedBasketItem);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}