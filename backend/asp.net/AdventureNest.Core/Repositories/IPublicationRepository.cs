using AdventureNest.Core.Models;

namespace AdventureNest.Core.Repositories
{
    public interface IPublicationRepository : IGenericRepository<Publication>
    {
        Task<List<Publication>> GetPublicationsWithProperties();

        Task<List<Publication>> GetPublicationsWithDescendingPrice();

        Task<List<Publication>> GetPublicationsWithAscendingPrice();

        Task<List<Publication>> GetPublicationsWithHouseTypes(string houseType);

        Task<List<Publication>> GetPublicationsWithBookingTypes(string bookingType);
    }
}
