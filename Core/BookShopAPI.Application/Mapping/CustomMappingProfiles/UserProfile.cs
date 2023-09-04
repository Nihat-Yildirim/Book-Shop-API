using AutoMapper;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping.CustomMappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserForAdminDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.UserAvatarUrl, o => o.MapFrom(s => FileUrlHelper.Generate(s.File.FilePath)))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.UpdatedDate, o => o.MapFrom(s => s.UpdatedDate))
                .ForMember(d => d.DeletedDate, o => o.MapFrom(s => s.DeletedDate));
        }
    }
}