﻿using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Category;

namespace ServicesLayer.AutoMapper.WebApplication
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category, CategoryListForUI>().ReverseMap();
            CreateMap<Category, CategoryListVM>().ReverseMap();
            CreateMap<Category, CategoryAddVM>().ReverseMap();
            CreateMap<Category, CategoryUpdateVM>().ReverseMap();
        }
    }
}
