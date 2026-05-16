using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TrainingClaude.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "password")
                return Ok(new { message = "Login successful" });

            return Unauthorized(new { message = "Invalid username or password" });
        }
    }

    public record LoginRequest(
        [Required][StringLength(50, MinimumLength = 3)] string Username,
        [Required][StringLength(100, MinimumLength = 6)] string Password
    );
}
