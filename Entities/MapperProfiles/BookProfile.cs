using AutoMapper;
using Azure;
using Entities.Concrete;
using Entities.DTOs.BookDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MapperProfiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<AddBookDto, Book>()
                .ForMember(destination => destination.PublisherId, operation => operation.MapFrom(source => source.PublisherId))
                .ForMember(destination => destination.StoreId, operation => operation.MapFrom(source => source.StoreId))
                .ForMember(destination => destination.AuthorId, operation => operation.MapFrom(source => source.AuthorId))
                .ForMember(destination => destination.BookName, operation => operation.MapFrom(source => source.BookName))
                .ForMember(destination => destination.Language, operation => operation.MapFrom(source => source.Language))
                .ForMember(destination => destination.ReleaseDate, operation => operation.MapFrom(source => source.ReleaseDate))
                .ForMember(destination => destination.ISBN, operation => operation.MapFrom(source => source.ISBN))
                .ForMember(destination => destination.PaperType, operation => operation.MapFrom(source => source.PaperType))
                .ForMember(destination => destination.SkinType, operation => operation.MapFrom(source => source.SkinType))
                .ForMember(destination => destination.PageOfNumber, operation => operation.MapFrom(source => source.PageOfNumber))
                .ForMember(destination => destination.Dimension, operation => operation.MapFrom(source => source.Dimension))
                .ForMember(destination => destination.BookDescription, operation => operation.MapFrom(source => source.BookDescription))
                .ForMember(destination => destination.Stock, operation => operation.MapFrom(source => source.Stock))
                .ForMember(destination => destination.Price, operation => operation.MapFrom(source => source.Price));

            CreateMap<UpdateBookDto, Book>()
                .ForMember(destination => destination.Id, operation => operation.MapFrom(source => source.BookId))
                .ForMember(destination => destination.PublisherId, operation => operation.MapFrom(source => source.PublisherId))
                .ForMember(destination => destination.AuthorId, operation => operation.MapFrom(source => source.AuthorId))
                .ForMember(destination => destination.BookName, operation => operation.MapFrom(source => source.BookName))
                .ForMember(destination => destination.Language, operation => operation.MapFrom(source => source.Language))
                .ForMember(destination => destination.ReleaseDate, operation => operation.MapFrom(source => source.ReleaseDate))
                .ForMember(destination => destination.ISBN, operation => operation.MapFrom(source => source.ISBN))
                .ForMember(destination => destination.PaperType, operation => operation.MapFrom(source => source.PaperType))
                .ForMember(destination => destination.SkinType, operation => operation.MapFrom(source => source.SkinType))
                .ForMember(destination => destination.PageOfNumber, operation => operation.MapFrom(source => source.PageOfNumber))
                .ForMember(destination => destination.Dimension, operation => operation.MapFrom(source => source.Dimension))
                .ForMember(destination => destination.BookDescription, operation => operation.MapFrom(source => source.BookDescription))
                .ForMember(destination => destination.Stock, operation => operation.MapFrom(source => source.Stock))
                .ForMember(destination => destination.Price, operation => operation.MapFrom(source => source.Price));
        }
    }
}
