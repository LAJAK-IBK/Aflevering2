using System;

namespace Aflevering2.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }
        public string SmileyName { get; set; }
        public string SmileyPath { get;set; }
        public int CompanyId { get; set; }
    }
}
