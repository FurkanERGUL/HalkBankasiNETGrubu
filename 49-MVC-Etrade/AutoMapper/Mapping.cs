using _49_MVC_Etrade.Models.DTOs;
using _49_MVC_Etrade.Models.Entities;
using _49_MVC_Etrade.Models.Entities.Deneme;
using _49_MVC_Etrade.Models.VMs;
using AutoMapper;

namespace _49_MVC_Etrade.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping() 
        {
            CreateMap<Category, CategoryListVM>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(cat => cat.Name)).ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ForMember(dest => dest.EmployeeFullName, opt => opt.MapFrom(src => src.EmployeeName + " " + src.EmployeeLastName));

            CreateMap<ProductCreateVM, Product>().ForMember(dest => dest.Category, opt => opt.Ignore()).ReverseMap();
        }
    }
}
