using AutoMapper;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.GetUserByPattern
{
    public class GetUserByPatternQueryHandler : IRequestHandler<GetUserByPatternQueryRequest, BaseDataResponse<List<UserForAdminDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IUserReadRepository _userReadRepository;

        public GetUserByPatternQueryHandler(IMapper mapper, IUserReadRepository userReadRepository)
        {
            _mapper = mapper;
            _userReadRepository = userReadRepository;
        }

        public async Task<BaseDataResponse<List<UserForAdminDto>>> Handle(GetUserByPatternQueryRequest request, CancellationToken cancellationToken)
        {
            var users = await _userReadRepository
                .GetWhere(x => x.FirstName.Contains(request.Pattern) || x.LastName.Contains(request.Pattern))
                .Include(x => x.File)
                .ToListAsync();
            var responseUser = _mapper.Map<List<UserForAdminDto>>(users);

            return new SuccessDataResponse<List<UserForAdminDto>>(responseUser);
        }
    }
}