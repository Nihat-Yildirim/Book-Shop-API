using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.Author.GetAllAuthors
{
    public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQueryRequest, BaseDataResponse<List<AuthorDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAllAuthorsQueryHandler(IAuthorReadRepository authorReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseDataResponse<List<AuthorDto>>> Handle(GetAllAuthorsQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorReadRepository.GetWhere(x => x.DeletedDate == null, false).Include(x => x.File).ToListAsync();
            var responseAuthors = _mapper.Map<List<AuthorDto>>(authors);

            return new SuccessDataResponse<List<AuthorDto>>(responseAuthors);
        }
    }
}