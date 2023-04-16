using AdventureNest.Core.Models;

namespace AdventureNest.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task CreateUserAsync(User user);
    }
}
