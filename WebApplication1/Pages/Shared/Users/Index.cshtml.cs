using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Pages.Shared.Users
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.INTEC_AGU_OCT22Context _context;

        public IndexModel(WebApplication1.Data.INTEC_AGU_OCT22Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User
                .Include(u => u.People).ToListAsync();
            }
        }
    }
}
