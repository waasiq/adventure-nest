using AdventureNest.Core.DTOs;

namespace AdventureNest.Core.Services
{
    public interface IAuthenticationService
    {
        Task<CustomResponseDto<TokenDto>> CreateToken(LoginDto loginDto);

        Task<CustomResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

        Task<CustomResponseDto<NoContentDto>> RevokeRefreshToken(string refreshToken);
    }
}
