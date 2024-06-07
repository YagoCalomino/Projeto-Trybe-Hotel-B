using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TrybeHotel.Dto;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("booking")]
  
    public class BookingController : Controller
    {
        private readonly IBookingRepository _repository;
        public BookingController(IBookingRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Policy = "Client")]
        public IActionResult Add([FromBody] BookingDtoInsert bookingInsert)
        {
            var token = HttpContext.User.Identity as ClaimsIdentity;
            var email = token?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            try
            {
                return Created("", _repository.Add(bookingInsert, email!));
            }
            catch (Exception error)
            {
                return BadRequest(new { message = error.Message });
            }
        }


        [HttpGet("{Bookingid}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Policy = "Client")]
        public IActionResult GetBooking(int Bookingid)
        {           
            var token = HttpContext.User.Identity as ClaimsIdentity;
            var email = token?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            try
            {
                if (email == null)
                    throw new Exception("User email not found in token");

                return Ok(_repository.GetBooking(Bookingid, email));
            }
            catch (Exception error)
            {
                return Unauthorized(new { message = error.Message });
            }
        }
    }
}