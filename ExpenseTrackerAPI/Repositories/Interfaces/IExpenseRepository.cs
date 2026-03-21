using ExpenseTrackerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTrackerAPI.Repositories.Interfaces
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetAllAsync();
        Task<Expense> GetByIdAsync(int id);
        Task AddAsync(Expense expense);
        Task UpdateAsync(Expense expense);
        Task DeleteAsync(int id);
    }
}