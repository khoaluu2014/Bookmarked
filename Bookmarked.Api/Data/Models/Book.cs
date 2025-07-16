using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMarked.Api.Data.Models;

[Table("Books")]
public class Book
{
    [Key]
    public int Id { get; set; }
    public string? ISBN { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public string? CoverArtUrl { get; set; }
}
