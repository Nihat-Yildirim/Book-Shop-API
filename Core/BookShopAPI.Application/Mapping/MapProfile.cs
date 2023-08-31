using AutoMapper;
using BookShopAPI.Application.CQRS.Commands.User.CustomerRegister;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserRegisterCommandRequest, User>();
            CreateMap<User,UserForAdminDto>();
        }
    }
}