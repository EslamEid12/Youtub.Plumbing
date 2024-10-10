using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Category;
using EntityLayer.WebApplication.ViewModels.Contact;

namespace ServicesLayer.AutoMapper.WebApplication
{
    public class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<ContactUs, ContactListForUI>().ReverseMap();
            CreateMap<ContactUs, ContactListVM>().ReverseMap();
            CreateMap<ContactUs, ContactAddVM>().ReverseMap();
            CreateMap<ContactUs, ContactUpdateVM>().ReverseMap();
        }
    }
}
