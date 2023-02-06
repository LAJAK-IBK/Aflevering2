using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Aflevering2.Models;
using System;
using System.Linq;

namespace Aflevering2.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new Aflevering2Context(serviceProvider.GetRequiredService<DbContextOptions<Aflevering2Context>>());
            
                // look for any data
                
                if (context.Company.Any() || context.Report.Any())
                {
                    //DB has already been seeded
                    return;
                }
                
                
                context.Company.AddRange(
                    new Company
                    {
                        //Id = 1,
                        Name = "Brd. Price",
                        Address = "Torvet 3, 7400 Herning",
                        CvrNumber = "11111111"

                    },

                    new Company
                    {
                        //Id = 2,
                        Name = "Den Kinesiske Mur",
                        Address = "Østergade 50, 7400 Herning",
                        CvrNumber = "22222222"
                    },

                    new Company
                    {
                        //Id = 3,
                        Name = "Backyardburger",
                        Address = "Bredgade 27, 7400 Herning",
                        CvrNumber = "33333333"
                    }

                );

                    context.SaveChanges();

                    context.Report.AddRange(
                    new Report
                    {
                        ReportDate = DateTime.Now,
                        SmileyName = "HappySmiley",
                        SmileyPath = "HappySmiley.jpg",
                        CompanyId = 1
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-1),
                        SmileyName = "HappySmiley",
                        SmileyPath = "HappySmiley.jpg",
                        CompanyId = 1
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-2),
                        SmileyName = "NeutralSmiley",
                        SmileyPath = "NeutralSmiley.jpg",
                        CompanyId = 1
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-3),
                        SmileyName = "SadSmiley",
                        SmileyPath = "SadSmiley.jpg",
                        CompanyId = 1
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-3),
                        SmileyName = "HappySmiley",
                        SmileyPath = "HappySmiley.jpg",
                        CompanyId = 2
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-2),
                        SmileyName = "HappySmiley",
                        SmileyPath = "HappySmiley.jpg",
                        CompanyId = 2
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-1),
                        SmileyName = "NeutralSmiley",
                        SmileyPath = "NeutralSmiley.jpg",
                        CompanyId = 2
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now,
                        SmileyName = "SadSmiley",
                        SmileyPath = "SadSmiley.jpg",
                        CompanyId = 2
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now,
                        SmileyName = "HappySmiley",
                        SmileyPath = "HappySmiley.jpg",
                        CompanyId = 3
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-2),
                        SmileyName = "HappySmiley",
                        SmileyPath = "HappySmiley.jpg",
                        CompanyId = 3
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-1),
                        SmileyName = "NeutralSmiley",
                        SmileyPath = "NeutralSmiley.jpg",
                        CompanyId = 3
                    },

                    new Report
                    {
                        ReportDate = DateTime.Now.AddYears(-3),
                        SmileyName = "SadSmiley",
                        SmileyPath = "SadSmiley.jpg",
                        CompanyId = 3
                    }
                );

                context.SaveChanges();
        }
    }
}
