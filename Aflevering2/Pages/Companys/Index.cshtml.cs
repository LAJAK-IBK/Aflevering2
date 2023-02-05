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
    public class IndexModel : PageModel
    {
        private readonly Aflevering2.Data.Aflevering2Context _context;

        public IndexModel(Aflevering2.Data.Aflevering2Context context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}
