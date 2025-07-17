using BookMarked.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMarked.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Note> Notes { get; set; }
}
