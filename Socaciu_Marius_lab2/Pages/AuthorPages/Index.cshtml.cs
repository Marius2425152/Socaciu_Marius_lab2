using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Socaciu_Marius_lab2.Models;

namespace Socaciu_Marius_lab2.Pages.AuthorPages;

public class IndexModel : PageModel
{
    private readonly Socaciu_Marius_lab2Context _context;

    public IndexModel(Socaciu_Marius_lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
