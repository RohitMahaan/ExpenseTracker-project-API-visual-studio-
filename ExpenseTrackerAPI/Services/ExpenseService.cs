using ExpenseTrackerAPI.Models;
using ExpenseTrackerAPI.Repositories.Interfaces;

namespace ExpenseTrackerAPI.Services
{
    public class ExpenseService
    {
        private readonly IExpenseRepository _repo;

        public ExpenseService(IExpenseRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Expense> Get(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task Add(Expense expense)
        {
            await _repo.AddAsync(expense);
        }

        public async Task Update(Expense expense)
        {
            await _repo.UpdateAsync(expense);
        }

        public async Task Delete(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}