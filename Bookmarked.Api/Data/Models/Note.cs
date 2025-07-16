using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMarked.Api.Data.Models;

[Table("Notes")]
public class Note
{
    [Key]
    public int Id { get; set; }
    public required string Quote { get; set; }
    public string? Thoughts { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    public int UserId { get; set; }
    public int BookId { get; set; }

    // TODO
    // Add navigation properties
}
