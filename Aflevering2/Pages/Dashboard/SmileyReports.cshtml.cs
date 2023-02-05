using Aflevering2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aflevering2.Pages.Dashboard
{
    public class SmileyReportsModel : PageModel
    {
        private readonly Aflevering2.Data.Aflevering2Context _context;

        public SmileyReportsModel(Aflevering2.Data.Aflevering2Context context)
        {
            _context = context;
        }

        public IList<Report> Report { get; set; }

        public async Task OnGetAsync()
        {
            Report = await _context.Report.ToListAsync();
        }
    }
}
