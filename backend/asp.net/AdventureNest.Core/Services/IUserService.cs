using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;

namespace AdventureNest.Core.Services
{
    public interface IUserService : IGenericService<User,UserDto>
    {   
        Task<CustomResponseDto<UserDto>> CreateUser(UserDto dto);
    }
}
