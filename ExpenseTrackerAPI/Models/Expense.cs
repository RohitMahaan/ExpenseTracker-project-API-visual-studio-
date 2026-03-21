using System;
using System.Collections.Generic;

namespace ExpenseTrackerAPI.Models
{
    public partial class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
    }
}
