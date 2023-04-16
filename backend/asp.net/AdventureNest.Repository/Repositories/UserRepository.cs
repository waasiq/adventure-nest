using AdventureNest.Core.Models;
using AdventureNest.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task CreateUserAsync(User user)
        {
            await _dbSet.AddAsync(user);
        }
    }
}
