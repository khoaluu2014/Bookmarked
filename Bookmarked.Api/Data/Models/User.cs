using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMarked.Api.Data.Models;

[Table("Users")]
public class User
{
    [Key]
    public int Id { get; set; }

    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
