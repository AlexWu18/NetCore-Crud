using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Pages.Shared.Users
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.Data.INTEC_AGU_OCT22Context _context;

        public CreateModel(WebApplication1.Data.INTEC_AGU_OCT22Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PeopleId"] = new SelectList(_context.People, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public User User { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
