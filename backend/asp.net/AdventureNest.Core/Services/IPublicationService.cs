using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;

namespace AdventureNest.Core.Services
{
    public interface IPublicationService : IGenericService<Publication,PublicationDto>
    {
        Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithProperties();

        Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithDescendingPrice();

        Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithAscendingPrice();

        Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithHouseTypes(string houseType);

        Task<CustomResponseDto<List<PublicationsWithPropertyDto>>> GetPublicationsWithBookingTypes(string bookingType);
    }
}
