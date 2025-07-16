using System.ComponentModel.DataAnnotations;

namespace BookMarked.Api.Data.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string? ISBN { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public string? CoverArtUrl { get; set; }
}
