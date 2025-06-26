using AutoMapper;
using ShippingAPI.DTOS;
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
            //city mapping
            CreateMap<City, cityDTO>()
     .ForMember(dest => dest.GoverrateName, opt => opt.MapFrom(src => src.Governorate.Name))
     .ReverseMap()
     .ForPath(dest => dest.Governorate.Name, opt => opt.MapFrom(src => src.GoverrateName));
            CreateMap<City,cityidDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.GoverrateName, opt => opt.MapFrom(src => src.Governorate.Name))
                .ForMember(dest => dest.PricePerKg, opt => opt.MapFrom(src => src.PricePerKg));
            CreateMap<cityDTO, City>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForPath(dest => dest.Governorate.Name, opt => opt.MapFrom(src => src.GoverrateName))
                .ForMember(dest => dest.PricePerKg, opt => opt.MapFrom(src => src.PricePerKg));
            CreateMap<cityidDTO, City>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.PricePerKg, opt => opt.MapFrom(src => src.PricePerKg))
                .ForPath(dest => dest.Governorate.Name, opt => opt.MapFrom(src => src.GoverrateName));

            //governorate mapping

            CreateMap<Governorate, governrateDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.RegionName, opt => opt.MapFrom(src => src.Region.Name))
                .ReverseMap();
            CreateMap<Governorate, governrateidDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.RegionName, opt => opt.MapFrom(src => src.Region.Name))
                .ReverseMap();
            //region mapping
            CreateMap<Region, regionidDTO>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                                .ForMember(dest => dest.governrateName, opt => opt.MapFrom(src => src.Governorates.Select(g => g.Name).ToList()))

                .ReverseMap();
            CreateMap<Region, regoinDTO>()
              
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.governrateName, opt => opt.MapFrom(src => src.Governorates.Select(g=>g.Name).ToList()))
                .ReverseMap();

        }
    }
}
