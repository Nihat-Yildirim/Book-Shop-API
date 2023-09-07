using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorById
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQueryRequest, BaseDataResponse<AuthorDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAuthorByIdQueryHandler(IMapper mapper, IAuthorReadRepository authorReadRepository)
        {
            _mapper = mapper;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseDataResponse<AuthorDto>> Handle(GetAuthorByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedAuthor = await _authorReadRepository.GetAuthorByAuthorPictureFileAsync(x => x.Id == request.Id && x.DeletedDate == null, false);
            var responseAuthor = _mapper.Map<AuthorDto>(selectedAuthor);

            return new SuccessDataResponse<AuthorDto>(responseAuthor);
        }
    }
}