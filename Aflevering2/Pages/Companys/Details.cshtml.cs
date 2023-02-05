using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aflevering2.Data;
using Aflevering2.Models;

namespace Aflevering2.Pages.Companys
{
    public class DetailsModel : PageModel
    {
        private readonly Aflevering2.Data.Aflevering2Context _context;

        public DetailsModel(Aflevering2.Data.Aflevering2Context context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company.FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
