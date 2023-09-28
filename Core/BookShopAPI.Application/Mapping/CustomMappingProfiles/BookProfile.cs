using AutoMapper;
using BookShopAPI.Application.CQRS.Commands.BookCommands.AddBook;
using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping.CustomMappingProfiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<AddBookCommandRequest, Book>()
                .ForMember(d => d.PublisherId, o => o.MapFrom(s => s.PublisherId))
                .ForMember(d => d.LanguageId , o=> o.MapFrom(s => s.LanguageId))
                .ForMember(d => d.BookName, o => o.MapFrom(s => s.BookName))
                .ForMember(d => d.ISBN, o => o.MapFrom(s => s.ISBN))
                .ForMember(d => d.PaperType, o => o.MapFrom(s => s.PaperType))
                .ForMember(d => d.SkinType, o => o.MapFrom(s => s.SkinType))
                .ForMember(d => d.Dimension, o => o.MapFrom(s => s.Dimension))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Description))
                .ForMember(d => d.ReleaseDate, o => o.MapFrom(s => s.ReleaseDate.ToShortDateString()))
                .ForMember(d => d.PageOfNumber , o => o.MapFrom(s => s.PageOfNumber))
                .ForMember(d => d.Stock, o => o.MapFrom(s => s.Stock))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Price))
                .ForMember(d => d.Authors,o => o.Ignore())
                .ForMember(d => d.Categories,o => o.Ignore());

            CreateMap<Book, ShortBookDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.BookName));

        }
    }
}