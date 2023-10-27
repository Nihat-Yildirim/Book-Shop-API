using BookShopAPI.Application.DTOs.BasketItemDTOs;
using BookShopAPI.Application.DTOs.OrderDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.OrderRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.OrderQueries.GetAllOrder
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQueryRequest, BaseDataResponse<List<OrderForAdminDto>>>
    {
        private readonly IOrderReadRepository _orderReadRepository;

        public GetAllOrderQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<BaseDataResponse<List<OrderForAdminDto>>> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var resultOrders = await _orderReadRepository.Table
                              .Include(x => x.PhoneNumber)
                              .Include(x => x.Address)
                              .Include(x => x.Basket)
                                  .ThenInclude(x => x.BasketItems)
                                      .ThenInclude(x => x.Book)
                                         .ThenInclude(x => x.BookPictures)
                                            .ThenInclude(x => x.File)
                              .ToListAsync();

            if (resultOrders.Count == 0)
                return new FailDataResponse<List<OrderForAdminDto>>();

            List<OrderForAdminDto> responseOrders = new();

            foreach (var order in resultOrders)
            {
                OrderForAdminDto responseOrder = new()
                {
                    OrderId = order.Id,
                    UserId = order.UserId,
                    PhoneNumber = new()
                    {
                        Id = order.PhoneNumber.Id,
                        PhoneNumber = order.PhoneNumber.PhoneNumber
                    },
                    Address = new()
                    {
                        Id = order.Address.Id,
                        AddressTitle = order.Address.AddressTitle,
                        Description = order.Address.Description,
                        OpenAddress = order.Address.OpenAddress,
                    },
                    Basket = new()
                    {
                        BasketId = order.Basket.Id,
                        BasketItems = order.Basket?.BasketItems?.ToList().Select(basketItem => new BasketItemDto
                        {
                            PublisherId = basketItem.Book.PublisherId,
                            BasketItemId = basketItem.Id,
                            BookId = basketItem.Book.Id,
                            BookName = basketItem.Book.BookName,
                            Quantity = basketItem.Quantity,
                            BookPictureUrl = FileUrlHelper.Generate(basketItem.Book.BookPictures.SingleOrDefault(x => x.ShowOrder == 1).File.FilePath),
                            Price = basketItem.Book.Price,
                        }).ToList(),
                    },
                    TotalPayment = (float)order.Basket?.BasketItems?.ToList().Select(basketItem => new {
                        Price = basketItem.Book.Price * basketItem.Quantity
                    }).ToList().Sum(x => x.Price),
                    Pay = order.Pay,
                    PaymentDate = order.PaymentDate,
                    Comfirm = order.Comfirm,
                    ComfirmedDate = order.ComfirmedDate,
                    Send = order.Send,
                    SendedDate = order.SendedDate
                };

                responseOrders.Add(responseOrder);
            }

            return new SuccessDataResponse<List<OrderForAdminDto>>(responseOrders);
        }
    }
}