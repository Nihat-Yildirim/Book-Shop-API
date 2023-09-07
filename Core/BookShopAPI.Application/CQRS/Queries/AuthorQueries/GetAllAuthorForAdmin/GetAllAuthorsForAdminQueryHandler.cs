using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthorForAdmin
{
    public class GetAllAuthorsForAdminQueryHandler : IRequestHandler<GetAllAuthorsForAdminQueryRequest, BaseDataResponse<List<AuthorForAdminDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAllAuthorsForAdminQueryHandler(IMapper mapper, IAuthorReadRepository authorReadRepository)
        {
            _mapper = mapper;
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseDataResponse<List<AuthorForAdminDto>>> Handle(GetAllAuthorsForAdminQueryRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorReadRepository.GetAll(false).Include(x => x.File).ToListAsync();
            var responseAuthors = _mapper.Map<List<AuthorForAdminDto>>(authors);
            
            return new SuccessDataResponse<List<AuthorForAdminDto>>(responseAuthors);
        }
    }
}