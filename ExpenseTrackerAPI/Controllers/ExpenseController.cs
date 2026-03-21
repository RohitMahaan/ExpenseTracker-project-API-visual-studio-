using Microsoft.AspNetCore.Mvc;
using ExpenseTrackerAPI.Services;
using ExpenseTrackerAPI.Models;

namespace ExpenseTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly ExpenseService _service;

        public ExpenseController(ExpenseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _service.Get(id);
            if (data == null) return NotFound();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            await _service.Add(expense);
            return Ok("Expense Added");
        }

        [HttpPut]
        public async Task<IActionResult> Update(Expense expense)
        {
            await _service.Update(expense);
            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok("Deleted");
        }
    }
}