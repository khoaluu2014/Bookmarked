using System.ComponentModel.DataAnnotations;

namespace BookMarked.Api.Data.Models;

public class Books
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text
}
