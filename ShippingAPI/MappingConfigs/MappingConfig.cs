using AutoMapper;
using ShippingAPI.DTOS.Register;
using ShippingAPI.DTOS.RegisterAndLogin;
using ShippingAPI.Models;

namespace ShippingAPI.MappingConfigs
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<RegisterDTO, ApplicationUser>()
          .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
          .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
          .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
          .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
          .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            CreateMap<ApplicationUser, UserProfileDTO>()
           .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
           .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
           .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
           .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
           .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
        }
    }
}
