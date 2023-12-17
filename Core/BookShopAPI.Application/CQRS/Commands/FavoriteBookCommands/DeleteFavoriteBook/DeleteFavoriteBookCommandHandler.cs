using BookShopAPI.Application.Repositories.FavoriteBookRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.DeleteFavoriteBook
{
    public class DeleteFavoriteBookCommandHandler : IRequestHandler<DeleteFavoriteBookCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFavoriteBookReadRepository _favoriteBookReadRepository;
        private readonly IFavoriteBookWriteRepository _favoriteBookWriteRepository;

        public DeleteFavoriteBookCommandHandler(IFavoriteBookReadRepository favoriteBookReadRepository, IFavoriteBookWriteRepository favoriteBookWriteRepository, IUnitOfWork unitOfWork)
        {
            _favoriteBookReadRepository = favoriteBookReadRepository;
            _favoriteBookWriteRepository = favoriteBookWriteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponse> Handle(DeleteFavoriteBookCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedFavoriteBook = await _favoriteBookReadRepository.GetSingleAsync(x => x.Id == request.Id, true);
            
            if (selectedFavoriteBook == null)
                return new FailNoDataResponse();

            _favoriteBookWriteRepository.Remove(selectedFavoriteBook);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}