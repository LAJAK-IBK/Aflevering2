using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aflevering2.Models;

namespace Aflevering2.Data
{
    public class Aflevering2Context : DbContext
    {
        public Aflevering2Context (DbContextOptions<Aflevering2Context> options)
            : base(options)
        {
        }

        public DbSet<Aflevering2.Models.Company> Company { get; set; }

        public DbSet<Aflevering2.Models.Report> Report { get; set; }
    }
}
