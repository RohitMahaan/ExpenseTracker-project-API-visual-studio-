using System;

namespace ExpenseTrackerAPI.DTOs
{
    public class ExpenseDTO
    {
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}