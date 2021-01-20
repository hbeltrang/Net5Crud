using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Net5Crud.Data;
using Net5Crud.Models;

namespace Net5Crud.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Net5Crud.Data.ApplicationDbContext _context;

        public IndexModel(Net5Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
