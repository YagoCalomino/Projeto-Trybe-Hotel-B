using Microsoft.AspNetCore.Mvc;
using TrybeHotel.Models;
using TrybeHotel.Repository;
using TrybeHotel.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace TrybeHotel.Controllers
{
    [ApiController]
    [Route("user")]

    public class UserController : Controller
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Policy = "Admin")]
        public IActionResult GetUsers()
        {
            try
            {
                return Ok(_repository.GetUsers());
            }
            catch (Exception error)
            {
                return Unauthorized(new { message = error.Message });
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserDtoInsert user)
        {
            try
            {
                var newUser = _repository.Add(user);
                return Created("", newUser);
            }
            catch (Exception error)
            {
                return Conflict(new { message = error.Message });
            }
        }
    }
}