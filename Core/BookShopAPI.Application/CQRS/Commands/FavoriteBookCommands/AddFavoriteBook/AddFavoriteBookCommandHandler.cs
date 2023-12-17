using BookShopAPI.Application.DTOs.FavoriteBookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Application.Repositories.FavoriteBookRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.AddFavoriteBook
{
    public class AddFavoriteBookCommandHandler : IRequestHandler<AddFavoriteBookCommandRequest, BaseDataResponse<FavoriteBookDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookReadRepository _bookReadRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IFavoriteBookWriteRepository _favoriteBookWriteRepository;

        public AddFavoriteBookCommandHandler(IUnitOfWork unitOfWork, IBookReadRepository bookReadRepository, IUserReadRepository userReadRepository, IFavoriteBookWriteRepository favoriteBookWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _bookReadRepository = bookReadRepository;
            _userReadRepository = userReadRepository;
            _favoriteBookWriteRepository = favoriteBookWriteRepository;
        }

        public async Task<BaseDataResponse<FavoriteBookDto>> Handle(AddFavoriteBookCommandRequest request, CancellationToken cancellationToken)
        {
            bool isUserExists = await _userReadRepository.AnyAsync(x => x.Id == request.UserId && x.DeletedDate == null);
            if (!isUserExists)
                return new FailDataResponse<FavoriteBookDto>();

            bool isBookExists = await _bookReadRepository.AnyAsync(x => x.Id == request.BookId && x.DeletedDate == null);
            if(!isBookExists)
                return new FailDataResponse<FavoriteBookDto>();

            FavoriteBook favoriteBook = new();
            favoriteBook.BookId = request.BookId;
            favoriteBook.UserId = request.UserId;

            await _favoriteBookWriteRepository.AddAsync(favoriteBook);
            await _unitOfWork.SaveChangesAsync();

            FavoriteBookDto response = new();
            response.BookId = favoriteBook.BookId;
            response.Id = favoriteBook.Id;

            return new SuccessDataResponse<FavoriteBookDto>(response);
        }
    }
}