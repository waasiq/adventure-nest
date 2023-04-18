using AdventureNest.API.Attributes;
using AdventureNest.API.Filters;
using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureNest.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Authorize]
    [ValidateFilter]
    public class UsersController : CustomController
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _service.GetAllAsync();

            return await CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var response = await _service.GetByIdAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost]
        [AllowAnonymous]
        [ServiceFilter(typeof(UserExistFilter))]
        public async Task<IActionResult> AddUser([FromBody] UserDto userDto)
        {
            var response = await _service.CreateUser(userDto);

            return await CreateActionResult(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] UserDto userDto,int id)
        {
            var response = await _service.Update(userDto,id);

            return await CreateActionResult(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response =await _service.RemoveAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost("range")]
        public async Task<IActionResult> AddUsers([FromBody] List<UserDto> dtos)
        {
            var response = await _service.AddRangeAsync(dtos);

            return await CreateActionResult(response);
        }

        [HttpDelete("range")]
        public async Task<IActionResult> DeleteUsers([FromBody] List<UserDto> dtos)
        {
            var response = await _service.RemoveRangeAsync(dtos);

            return await CreateActionResult(response);
        }

    }
}
