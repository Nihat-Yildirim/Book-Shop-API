using AutoMapper;
using BookShopAPI.Application.CQRS.Commands.User.UserRegister;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserRegisterCommandRequest, User>();
        }
    }
}