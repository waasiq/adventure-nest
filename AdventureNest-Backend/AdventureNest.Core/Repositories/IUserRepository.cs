using AdventureNest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task CreateUserAsync(User user);
    }
}
