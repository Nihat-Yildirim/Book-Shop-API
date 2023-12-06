using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.ViewRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.ViewCommands
{
    public class AddViewCommandHandler : IRequestHandler<AddViewCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IViewWriteRepository _viewWriteRepository;

        public AddViewCommandHandler(IUnitOfWork unitOfWork, IBookReadRepository bookReadRepository, IViewWriteRepository viewWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _viewWriteRepository = viewWriteRepository;
        }

        public async Task<BaseResponse> Handle(AddViewCommandRequest request, CancellationToken cancellationToken)
        {
            bool bookExists = await _bookReadRepository.AnyAsync(x => x.Id == request.BookId);
            if (!bookExists)
                return new FailNoDataResponse();

            View view = new();
            view.BookId = request.BookId;

            await _viewWriteRepository.AddAsync(view);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}