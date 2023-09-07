using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByPublisherId
{
    public class GetBooksByPublisherIdQueryHandler : IRequestHandler<GetBooksByPublisherIdQueryRequest, BaseDataResponse<List<BookDto>>>
    {
        private readonly IBookReadRepository _bookReadRepository;
        public GetBooksByPublisherIdQueryHandler(IBookReadRepository bookReadRepository)
        {
            _bookReadRepository = bookReadRepository;
        }

        public async Task<BaseDataResponse<List<BookDto>>> Handle(GetBooksByPublisherIdQueryRequest request, CancellationToken cancellationToken)
        {
            var responseDatas = await _bookReadRepository.GetBookDtosAsync(new Pagination { Page = request.Page, Size = request.Size }, x => x.Publisher.Id == request.Id);
            return new SuccessDataResponse<List<BookDto>>(responseDatas);
        }
    }
}