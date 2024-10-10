using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Portfolio;

namespace ServicesLayer.AutoMapper.WebApplication
{
    public class PortfolioMapper : Profile
    {
        public PortfolioMapper()
        {
            CreateMap<Portfolio, PortfolioListForUI>().ReverseMap();
            CreateMap<Portfolio, PortfolioListVM>().ReverseMap();
            CreateMap<Portfolio, PortfolioAddVM>().ReverseMap();
            CreateMap<Portfolio, PortfolioUpdateVM>().ReverseMap();
        }
    }
}
