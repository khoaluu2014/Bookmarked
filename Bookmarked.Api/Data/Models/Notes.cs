namespace BookMarked.Api.Data.Models;

public class Note
{
    public int Id { get; set; }
    public required string Quote { get; set; }
    public string? Thoughts { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
