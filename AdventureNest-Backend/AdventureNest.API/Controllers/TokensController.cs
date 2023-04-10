using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureNest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokensController : CustomController
    {
        private readonly IGenericService<Token, TokenDto> _service;

        public TokensController(IGenericService<Token, TokenDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTokens()
        {
            var response = await _service.GetAllAsync();

            return await CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTokenById(int id)
        {
            var response = await _service.GetByIdAsync(id);

            return await CreateActionResult(response);
        }
    }
}
