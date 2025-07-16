using System.ComponentModel.DataAnnotations;

namespace BookMarked.Api.Data.Models;

public class Users
{
    [Key]
    public int Id { get; set; }

    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
