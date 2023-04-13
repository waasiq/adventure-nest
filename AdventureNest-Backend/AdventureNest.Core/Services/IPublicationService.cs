using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
