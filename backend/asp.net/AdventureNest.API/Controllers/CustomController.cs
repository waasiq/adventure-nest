using AdventureNest.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureNest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        [NonAction]
        public async Task<IActionResult> CreateActionResult<T>(CustomResponseDto<T> customResponseDto) where T : class
        {
            //if (customResponseDto.StatusCode == 204)
            //{
            //    return new ObjectResult(null)
            //    {
            //        StatusCode = customResponseDto.StatusCode
            //    };
            //}

            //return new ObjectResult(customResponseDto)
            //{
            //    StatusCode = customResponseDto.StatusCode
            //};
            return new ObjectResult(customResponseDto)
            {
                StatusCode = customResponseDto.StatusCode
            };
        }
    }
}
