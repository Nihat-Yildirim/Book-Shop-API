﻿using AutoMapper;
using BookShopAPI.Application.CQRS.Commands.AddressCommands.AddAddress;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthor;
using BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasketItem;
using BookShopAPI.Application.CQRS.Commands.CommentCommands.AddComment;
using BookShopAPI.Application.CQRS.Commands.CommentCommands.AddCommentRating;
using BookShopAPI.Application.CQRS.Commands.UserCommands.CustomerRegister;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.DTOs.DistrictDTOs;
using BookShopAPI.Application.DTOs.NeighbourhoodDTOs;
using BookShopAPI.Application.DTOs.ProvinceDTOs;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserRegisterCommandRequest, User>();
            CreateMap<Province , ProvinceDto>();
            CreateMap<District, DistrictDto>();
            CreateMap<Neighbourhood, NeighbourhoodDto>();
            CreateMap<AddAddressCommandRequest, Address>();
            CreateMap<AddAuthorCommandRequest, Author>();
            CreateMap<Category, CategoryDto>();
            CreateMap<AddCommentCommandRequest, CommentEntity>();
            CreateMap<AddBasketItemCommandRequest, BasketItem>();
            CreateMap<AddCommentRatingCommandRequest, CommentRating>();
        }
    }
}