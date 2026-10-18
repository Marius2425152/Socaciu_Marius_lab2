using Microsoft.EntityFrameworkCore;
using Socaciu_Marius_lab2.Models;

public class Socaciu_Marius_lab2Context(DbContextOptions<Socaciu_Marius_lab2Context> options) : DbContext(options)
{
    public DbSet<Socaciu_Marius_lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Socaciu_Marius_lab2.Models.Publisher> Publisher { get; set; }
    public DbSet<Socaciu_Marius_lab2.Models.Author> Author { get; set; }
}
