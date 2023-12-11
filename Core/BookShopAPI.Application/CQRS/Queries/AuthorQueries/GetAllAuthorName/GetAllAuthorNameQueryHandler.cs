using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthorName
{
    public class GetAllAuthorNameQueryHandler : IRequestHandler<GetAllAuthorNameQueryRequest, BaseDataResponse<List<ShortAuthorDto>>>
    {
        private readonly IAuthorReadRepository _authorReadRepository;

        public GetAllAuthorNameQueryHandler(IAuthorReadRepository authorReadRepository)
        {
            _authorReadRepository = authorReadRepository;
        }

        public async Task<BaseDataResponse<List<ShortAuthorDto>>> Handle(GetAllAuthorNameQueryRequest request, CancellationToken cancellationToken)
        {
            var datas = await _authorReadRepository.GetWhere(x => x.DeletedDate == null, false).ToListAsync();
            List<ShortAuthorDto> response = new();

            foreach (var data in datas)
                response.Add(new ShortAuthorDto
                {
                    Id = data.Id,
                    Name = data.Name,
                });

            return new SuccessDataResponse<List<ShortAuthorDto>>(response); 
        }
    }
}