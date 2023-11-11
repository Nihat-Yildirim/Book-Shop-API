using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByISBN
{
    public class GetBookByISBNQueryHandler : IRequestHandler<GetBookByISBNQueryRequest, BaseDataResponse<BookDetailDto>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBookByISBNQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<BookDetailDto>> Handle(GetBookByISBNQueryRequest request, CancellationToken cancellationToken)
        {
            var responseData = await _bookReadRepository.GetSingleBookBookDetailDtoAsync(x => x.ISBN == request.ISBN);
            return new SuccessDataResponse<BookDetailDto>(responseData);
        }
    }
}