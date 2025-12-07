using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // <-- 1. Needed for ToListAsync(), FindAsync(), etc.
using Datalayer.Data;              // <-- 2. Needed for InventoryDbContext
using Datalayer.Model;             // <-- 3. Needed for the Category model

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockHistoryController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public StockHistoryController(InventoryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _context.StockHistory
                .Include(h => h.Product)
                .ToListAsync();

            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _context.StockHistory.FindAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StockHistory history)
        {
            history.Date = DateTime.Now;

            _context.StockHistory.Add(history);

            // Update product quantity
            var product = await _context.Products.FindAsync(history.ProductId);

            if (product != null)
            {
                if (history.ChangeType == "Stock-In")
                    product.Quantity += history.ChangeAmount;

                if (history.ChangeType == "Stock-Out")
                    product.Quantity -= history.ChangeAmount;
            }

            await _context.SaveChangesAsync();
            return Ok(history);
        }
    }
}
