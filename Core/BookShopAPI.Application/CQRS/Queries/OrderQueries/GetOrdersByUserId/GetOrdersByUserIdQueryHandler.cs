using BookShopAPI.Application.DTOs.BasketItemDTOs;
using BookShopAPI.Application.DTOs.OrderDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Application.Repositories.OrderRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.OrderQueries.GetOrdersByUserId
{
    public class GetOrdersByUserIdQueryHandler : IRequestHandler<GetOrdersByUserIdQueryRequest, BaseDataResponse<List<OrderDto>>>
    {
        private readonly IOrderReadRepository _orderReadRepository;

        public GetOrdersByUserIdQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<BaseDataResponse<List<OrderDto>>> Handle(GetOrdersByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var resultOrders = await _orderReadRepository.Table
                              .Include(x => x.PhoneNumber)
                              .Include(x => x.Address)
                              .Include(x => x.Basket)
                                  .ThenInclude(x => x.BasketItems)
                                      .ThenInclude(x => x.Book)
                                         .ThenInclude(x => x.BookPictures)
                                            .ThenInclude(x => x.File)
                              .Where(x => x.UserId == request.UserId)
                              .ToListAsync();

            if (resultOrders.Count == 0)
                return new FailDataResponse<List<OrderDto>>();

            List<OrderDto> responseOrders = new();
            
            foreach(var order in resultOrders)
            {
                OrderDto responseOrder = new()
                {
                    OrderId = order.Id,
                    UserId = request.UserId,
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
                        Province = order.Address.Province,
                        District = order.Address.District,
                        Neighbourhood = order.Address.Neighbourhood,
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
                    Comfirm = order.Comfirm,
                    Send = order.Send,
                };

                responseOrders.Add(responseOrder);
            }

            return new SuccessDataResponse<List<OrderDto>>(responseOrders);
        }
    }
}