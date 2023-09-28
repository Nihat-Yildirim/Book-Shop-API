using AutoMapper;
using BookShopAPI.Application.DTOs.PublisherDTOs;
using BookShopAPI.Application.Helpers.FileUrl;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping.CustomMappingProfiles
{
    public class PublisherProfile : Profile
    {
        public PublisherProfile()
        {
            CreateMap<Publisher,PublisherDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => FileUrlHelper.Generate(s.File.FilePath)));

            CreateMap<Publisher, PublisherForAdminDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => FileUrlHelper.Generate(s.File.FilePath)))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(s => s.CreatedDate))
                .ForMember(d => d.UpdatedDate, o => o.MapFrom(s => s.UpdatedDate))
                .ForMember(d => d.DeletedDate, o => o.MapFrom(s => s.DeletedDate));
        }
    }
}