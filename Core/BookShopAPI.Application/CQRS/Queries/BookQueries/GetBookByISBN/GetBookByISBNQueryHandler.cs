using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByISBN
{
    public class GetBookByISBNQueryHandler : IRequestHandler<GetBookByISBNQueryRequest, BaseDataResponse<BookDto>>
    {
        private readonly IBookReadRepository _bookReadRepository;

        public GetBookByISBNQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<BookDto>> Handle(GetBookByISBNQueryRequest request, CancellationToken cancellationToken)
        {
            var responseData = await _bookReadRepository.GetSingleBookDtoAsync(x => x.ISBN == request.ISBN);
            return new SuccessDataResponse<BookDto>(responseData);
        }
    }
}