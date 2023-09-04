using AutoMapper;
using BookShopAPI.Application.CQRS.Commands.Address.AddAddress;
using BookShopAPI.Application.CQRS.Commands.Author.AddAuthor;
using BookShopAPI.Application.CQRS.Commands.PhoneNumber.AddPhoneNumber;
using BookShopAPI.Application.CQRS.Commands.User.CustomerRegister;
using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.PhoneNumberDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserRegisterCommandRequest, User>();
            CreateMap<AddAddressCommandRequest, Address>();
            CreateMap<Address, GetAddressForAdminDto>();
            CreateMap<Address, GetAddressDto>();
            CreateMap<AddPhoneNumberCommandRequest, PhoneNumberEntity>();
            CreateMap<PhoneNumberEntity, PhoneNumberForAdminDto>();
            CreateMap<PhoneNumberEntity, PhoneNumberDto>();
            CreateMap<AddAuthorCommandRequest, Author>();
        }
    }
}