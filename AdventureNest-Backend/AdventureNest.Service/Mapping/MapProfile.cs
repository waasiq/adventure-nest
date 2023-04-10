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
        }
    }
}
