using Aflevering2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Aflevering2.Pages.Dashboard
{
    public class InfoCompanysModel : PageModel
    {
        private readonly Aflevering2.Data.Aflevering2Context _context;

        public InfoCompanysModel(Aflevering2.Data.Aflevering2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company.Include(c => c.ListOfReports).FirstOrDefaultAsync(m => m.Id == id);

            Company.OrderReports();

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
