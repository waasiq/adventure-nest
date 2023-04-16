using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AutoMapper;

namespace AdventureNest.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Booking, BookingDto>().ReverseMap();
            CreateMap<Property, PropertyDto>().ReverseMap();
            CreateMap<Publication, PublicationDto>().ReverseMap();
            CreateMap<Token, TokenDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Publication, PublicationsWithPropertyDto>().ReverseMap();

            CreateMap<Publication, PublicationsWithPropertyDto>()
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Property.Country))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Property.City))
                .ForMember(dest => dest.PropertyType, opt => opt.MapFrom(src => src.Property.PropertyType))
                .ForMember(dest => dest.BookingType, opt => opt.MapFrom(src => src.Property.BookingType))
                .ForMember(dest => dest.PhotographsPathList, opt => opt.MapFrom(src => src.Property.PhotographsPathList));
        }
    }
}
