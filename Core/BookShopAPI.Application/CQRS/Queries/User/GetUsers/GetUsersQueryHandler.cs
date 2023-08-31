using AutoMapper;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.User.GetUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQueryRequest, BaseDataResponse<List<UserForAdminDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IUserReadRepository _userReadRepository;

        public GetUsersQueryHandler(IUserReadRepository userReadRepository, IMapper mapper)
        {
            _userReadRepository = userReadRepository;
            _mapper = mapper;
        }

        public async Task<BaseDataResponse<List<UserForAdminDto>>> Handle(GetUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var resultUsers = await _userReadRepository.GetAll(false).ToListAsync();

            var responseUsers = _mapper.Map<List<UserForAdminDto>>(resultUsers);

            return new SuccessDataResponse<List<UserForAdminDto>>(responseUsers);
        }
    }
}