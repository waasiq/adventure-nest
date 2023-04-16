using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;

namespace AdventureNest.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
    }
}
