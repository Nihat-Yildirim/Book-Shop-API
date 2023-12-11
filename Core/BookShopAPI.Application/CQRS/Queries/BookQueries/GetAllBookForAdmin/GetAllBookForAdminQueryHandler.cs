using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBookForAdmin
{
    public class GetAllBookForAdminQueryHandler : IRequestHandler<GetAllBookForAdminQueryRequest, BaseDataResponse<BookForAdminDto>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetAllBookForAdminQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<BookForAdminDto>> Handle(GetAllBookForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            int bookCount = _bookReadRepository.GetWhere(x => x.DeletedDate == null).Count();
            var paginationDatas = await _bookReadRepository.GetBookDtosAsync(new Pagination { Page = request.Page, Size = request.Size });

            BookForAdminDto bookForAdminDto = new();
            bookForAdminDto.Books = paginationDatas;
            bookForAdminDto.BookCount = bookCount;

            return new SuccessDataResponse<BookForAdminDto>(bookForAdminDto);
        }
    }
}