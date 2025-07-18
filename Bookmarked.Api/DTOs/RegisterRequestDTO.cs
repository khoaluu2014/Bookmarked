using System.ComponentModel.DataAnnotations;

namespace BookMarked.Api.DTOs;

public class RegisterRequestDto
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MinLength(6)]
    public required string Password { get; set; }
}
