using Aflevering2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aflevering2.Pages.Dashboard
{
    public class SmileyCompanysModel : PageModel
    {
        private readonly Aflevering2.Data.Aflevering2Context _context;

        public SmileyCompanysModel(Aflevering2.Data.Aflevering2Context context)
        {
            _context = context;
        }

        public IList<Company> Company { get; set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.Include(c => c.ListOfReports).ToListAsync();
            
            foreach (var comp in Company)
            {
                comp.OrderReports();
            }
        }

        
    }
}
