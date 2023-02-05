using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Aflevering2.Models
{
    public class Company
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 8)]
        [RegularExpression(@"^(\d{8})$")]
        public string CvrNumber { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        public IList<Report> ListOfReports { get; set; }

        // Method to order Reports
        public void OrderReports()
        {
            ListOfReports = ListOfReports.OrderByDescending(r => r.ReportDate).ToList();
        }
    }
}
