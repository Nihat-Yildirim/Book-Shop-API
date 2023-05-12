using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.CategoryDTOs;
using Microsoft.Identity.Client.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.MapperProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<AddCategoryDto, Category>()
                .ForMember(destination => destination.CategoryName, operation => operation.MapFrom(source => source.CategoryName))
                .ForMember(destination => destination.ParentId, operation => operation.MapFrom(source => source.ParentCategoryId));

            CreateMap<UpdateCategoryDto, Category>()
                .ForMember(destination => destination.CategoryName, operation => operation.MapFrom(source => source.NewCategoryName))
                .ForMember(destination => destination.Id, operation => operation.MapFrom(source => source.CategoryId));
        }
    }
}