using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByIdForAdmin
{
    public class GetAuthorByIdForAdminQueryHandler : IRequestHandler<GetAuthorByIdForAdminQueryRequest, BaseDataResponse<AuthorForAdminDto>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAuthorByIdForAdminQueryHandler(IMapper mapper, IAuthorReadRepository authorReadRepository)
        {
            _mapper = mapper;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseDataResponse<AuthorForAdminDto>> Handle(GetAuthorByIdForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorReadRepository.GetAuthorByAuthorPictureFileAsync(x => x.Id == request.Id, false);
            var responseAuthor = _mapper.Map<AuthorForAdminDto>(author);

            return new SuccessDataResponse<AuthorForAdminDto>(responseAuthor);
        }
    }
}