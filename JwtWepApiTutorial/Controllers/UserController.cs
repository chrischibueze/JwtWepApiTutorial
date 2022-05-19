using JwtWepApiTutorial.Dto;
using JwtWepApiTutorial.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtWepApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IuserRepository _userRepository;

        public UserController(IuserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto request)
        {
        }

    }
}
