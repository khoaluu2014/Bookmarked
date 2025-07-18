using BookMarked.Api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BookMarked.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterRequestDto request)
    {
        return Ok();
    }
}
