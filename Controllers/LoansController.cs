using LoanManagementAPI.Data;
using LoanManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoansController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoansController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetLoans()
        {
            return Ok(_context.Loans.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> CreateLoan([FromBody] Loan loan)
        {
            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();

            return Ok("Loan created successfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if (loan == null) return NotFound("Loan not found!");

            _context.Loans.Remove(loan);
            await _context.SaveChangesAsync();

            return Ok("Loan deleted successfully!");
        }
    }
}
