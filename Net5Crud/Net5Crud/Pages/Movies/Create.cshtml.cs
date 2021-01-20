using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Net5Crud.Data;
using Net5Crud.Models;

namespace Net5Crud.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Net5Crud.Data.ApplicationDbContext _context;

        public CreateModel(Net5Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            TempData["message"] = "Item created successfully";

            return RedirectToPage("./Index");
        }
    }
}
