using AdventureNest.Core.DTOs;
using AdventureNest.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureNest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PublicationsController : CustomController
    {
        private readonly IPublicationService _service;


        public PublicationsController(IPublicationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPublications()
        {
            var response = await _service.GetAllAsync();

            return await CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPublicationById(int id)
        {
            var response = await _service.GetByIdAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddPublication([FromBody] PublicationDto publicationDto)
        {
            var response = await _service.AddAsync(publicationDto);

            return await CreateActionResult(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePublication([FromBody] PublicationDto publicationDto, int id)
        {
            var response = await _service.Update(publicationDto, id);

            return await CreateActionResult(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublication(int id)
        {
            var response = await _service.RemoveAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost("range")]
        public async Task<IActionResult> AddPublications([FromBody] List<PublicationDto> dtos)
        {
            var response = await _service.AddRangeAsync(dtos);

            return await CreateActionResult(response);
        }

        [HttpDelete("range")]
        public async Task<IActionResult> DeletePublications([FromBody] List<PublicationDto> dtos)
        {
            var response = await _service.RemoveRangeAsync(dtos);

            return await CreateActionResult(response);
        }

        [HttpGet("publications-with-property")]
        [AllowAnonymous]
        public  async Task<IActionResult> GetPublicationsWithProperties()
        {
            var response = await _service.GetPublicationsWithProperties();

            return await CreateActionResult(response);
        }

        [HttpGet("publications-orderBy-desc")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicationsWithDescendingPrice()
        {
            var response = await _service.GetPublicationsWithDescendingPrice();

            return await CreateActionResult(response);
        }

        [HttpGet("publications-orderBy-asc")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicationsWithAscendingPrice()
        {
            var response = await _service.GetPublicationsWithAscendingPrice();

            return await CreateActionResult(response);
        }
    }
}
