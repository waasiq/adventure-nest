using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.Repositories
{
    public interface IPublicationRepository : IGenericRepository<Publication>
    {
        Task<List<PublicationAndPropertyDTO>> GetPublicationsWithProperties();

        Task<List<PublicationAndPropertyDTO>> GetPublicationsWithDescendingPrice();

        Task<List<PublicationAndPropertyDTO>> GetPublicationsWithAscendingPrice();
    }
}
