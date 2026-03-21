using ExpenseTrackerAPI.Models;
using ExpenseTrackerAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerAPI.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly ExpenseTrackerDBContext _context;

        public ExpenseRepository(ExpenseTrackerDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Expense>> GetAllAsync()
        {
            return await _context.Expenses.ToListAsync();
        }

        public async Task<Expense> GetByIdAsync(int id)
        {
            return await _context.Expenses.FindAsync(id);
        }

        public async Task AddAsync(Expense expense)
        {
            await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Expense expense)
        {
            _context.Expenses.Update(expense);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var exp = await _context.Expenses.FindAsync(id);
            if (exp != null)
            {
                _context.Expenses.Remove(exp);
                await _context.SaveChangesAsync();
            }
        }
    }
}