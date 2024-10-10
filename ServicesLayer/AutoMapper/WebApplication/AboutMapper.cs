﻿using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.AboutVM;

namespace ServicesLayer.AutoMapper.WebApplication
{
    public class AboutMapper : Profile
    {
        public AboutMapper()
        {
            CreateMap<About, AboutListForUI>().ReverseMap();
            CreateMap<About, AboutListVM>().ReverseMap();
            CreateMap<About, AboutAddVM>().ReverseMap();
            CreateMap<About, AboutUpdateVM>().ReverseMap();
        }
    }
}
