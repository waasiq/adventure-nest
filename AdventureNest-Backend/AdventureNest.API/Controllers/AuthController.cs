using AdventureNest.Core.DTOs;
using AdventureNest.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureNest.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : CustomController
    {
        private readonly IAuthenticationService _service;

        public AuthController(IAuthenticationService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateToken(LoginDto dto)
        {
            var result = await _service.CreateToken(dto);

            return await CreateActionResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTokenByRefreshToken(RefreshTokenDto refreshTokenDto)
        {
            var result = await _service.CreateTokenByRefreshToken(refreshTokenDto.Token);

            return await CreateActionResult(result);

        }

        [HttpPost]
        public async Task<IActionResult> RevokeRefreshToken(RefreshTokenDto refreshTokenDto)
        {
            var result = await _service.RevokeRefreshToken(refreshTokenDto.Token);

            return await CreateActionResult(result);

        }
    }
}
