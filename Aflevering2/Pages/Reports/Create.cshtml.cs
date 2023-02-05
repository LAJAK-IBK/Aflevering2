using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Aflevering2.Data;
using Aflevering2.Models;

namespace Aflevering2.Pages.Reports
{
    public class CreateModel : PageModel
    {
        private readonly Aflevering2.Data.Aflevering2Context _context;

        public CreateModel(Aflevering2.Data.Aflevering2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Companys = _context.Company.ToList();

            return Page();
        }

        [BindProperty]
        public Report Report { get; set; }

        // Liste af Companys som bruges til at finde CompanyId
        [BindProperty]
        public List<Company> Companys { get; set; } = new List<Company>();


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Report.Add(Report);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
