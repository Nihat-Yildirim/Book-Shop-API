using BookShopAPI.Application.Repositories.OrderRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OrderCommands.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderReadRepository _orderReadRepository;

        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork, IOrderReadRepository orderReadRepository)
        {
            _unitOfWork = unitOfWork;
            _orderReadRepository = orderReadRepository;
        }

        public async Task<BaseResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedOrder = await _orderReadRepository.GetByIdAsync(request.OrderId);
            if (selectedOrder == null)
                return new FailNoDataResponse();

            if(request.Comfirm == false)
                return new FailNoDataResponse();

            if (request.Comfirm)
            {
                selectedOrder.Comfirm = true;
                selectedOrder.ComfirmedDate = DateTime.Now;
            }

            if (request.Send)
            {
                selectedOrder.Send = true;
                selectedOrder.SendedDate = DateTime.Now;
            }

            await _unitOfWork.SaveChangesAsync();
            return new SuccesNoDataResponse();
        }
    }
}