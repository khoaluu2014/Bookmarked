using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMarked.Api.Data.Models;

public class Note
{
    [Key]
    public int Id { get; set; }
    public required string Quote { get; set; }
    public string? Thoughts { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    [ForeignKey]
    public int UserId { get; set; }
}
