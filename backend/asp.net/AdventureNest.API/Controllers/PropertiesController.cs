using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureNest.API.Controllers
{
    [Route("api/properties")]
    [ApiController]

    public class PropertiesController : CustomController
    {
        private readonly IGenericService<Property, PropertyDto> _service;

        public PropertiesController(IGenericService<Property, PropertyDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProperties()
        {
            var response = await _service.GetAllAsync();

            return await CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropertyById(int id)
        {
            var response = await _service.GetByIdAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddProperty([FromBody] PropertyDto propertyDto)
        {
            var response = await _service.AddAsync(propertyDto);

            return await CreateActionResult(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProperty([FromBody] PropertyDto propertyDto, int id)
        {
            var response = await _service.Update(propertyDto, id);

            return await CreateActionResult(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            var response = await _service.RemoveAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost("range")]
        public async Task<IActionResult> AddProperties([FromBody] List<PropertyDto> dtos)
        {
            var response = await _service.AddRangeAsync(dtos);

            return await CreateActionResult(response);
        }

        [HttpDelete("range")]
        public async Task<IActionResult> DeleteProperties([FromBody] List<PropertyDto> dtos)
        {
            var response = await _service.RemoveRangeAsync(dtos);

            return await CreateActionResult(response);
        }
    }
}
