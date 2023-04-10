using AdventureNest.Core.DTOs;
using AdventureNest.Core.Models;
using AdventureNest.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureNest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookingsController : CustomController
    {
        private readonly IGenericService<Booking, BookingDto> _service;

        public BookingsController(IGenericService<Booking, BookingDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookings()
        {
            var response = await _service.GetAllAsync();

            return await CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingById(int id)
        {
            var response = await _service.GetByIdAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking([FromBody] BookingDto bookingDto)
        {
            var response = await _service.AddAsync(bookingDto);

            return await CreateActionResult(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] BookingDto bookingDto, int id)
        {
            var response = await _service.Update(bookingDto, id);

            return await CreateActionResult(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response = await _service.RemoveAsync(id);

            return await CreateActionResult(response);
        }

        [HttpPost("Range")]
        public async Task<IActionResult> AddBookings([FromBody] List<BookingDto> dtos)
        {
            var response = await _service.AddRangeAsync(dtos);

            return await CreateActionResult(response);
        }

        [HttpDelete("Range")]
        public async Task<IActionResult> DeleteBookings([FromBody] List<BookingDto> dtos)
        {
            var response = await _service.RemoveRangeAsync(dtos);

            return await CreateActionResult(response);
        }
    }
}
