using AutoMapper;
using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping.CustomMappingProfiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorForAdminDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Autobiography, o => o.MapFrom(s => s.Autobiography))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => FileUrlHelper.Generate(s.File.FilePath)))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.UpdatedDate, o => o.MapFrom(s => s.UpdatedDate))
                .ForMember(d => d.DeletedDate, o => o.MapFrom(s => s.DeletedDate));

            CreateMap<Author, AuthorDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Autobiography, o => o.MapFrom(s => s.Autobiography))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => FileUrlHelper.Generate(s.File.FilePath)));
        }
    }
}