using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureNest.Core.Services
{
    public interface IUserService : IGenericService<User,UserDto>
    {   
        Task<CustomResponseDto<UserDto>> CreateUser(UserDto dto);
    }
}
