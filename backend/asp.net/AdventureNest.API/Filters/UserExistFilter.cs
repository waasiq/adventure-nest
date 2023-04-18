using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AdventureNest.API.Filters
{
    public class UserExistFilter : IAsyncActionFilter 
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<User, UserDto> _service;

        public UserExistFilter(IGenericService<User, UserDto> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var requestObject = context.ActionArguments.FirstOrDefault(x => x.Value is UserDto).Value;
            
            var userDto = _mapper.Map<UserDto>(requestObject);

            if(userDto.Email is null)
            {
                await next.Invoke();
                return;
            }
           
            var control = await _service.AnyAsync(x => x.Email == userDto.Email);
            var y = 5;
            if (control)
            {
                context.Result = new BadRequestObjectResult(CustomResponseDto<NoContentDto>.Fail(400, "This email is registered."));
            }
            else
            {
                await next.Invoke();
                return;
            }

            
        }
    }
}
