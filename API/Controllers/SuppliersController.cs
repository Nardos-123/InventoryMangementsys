using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // <-- 1. Needed for ToListAsync(), FindAsync(), etc.
using Datalayer.Data;              // <-- 2. Needed for InventoryDbContext
using Datalayer.Model;             // <-- 3. Needed for the Category model

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public SuppliersController(InventoryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Suppliers.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _context.Suppliers.FindAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Supplier model)
        {
            _context.Suppliers.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Supplier updated)
        {
            var item = await _context.Suppliers.FindAsync(id);
            if (item == null) return NotFound();

            item.SupplierName = updated.SupplierName;
            item.ContactInfo = updated.ContactInfo;

            await _context.SaveChangesAsync();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Suppliers.FindAsync(id);
            if (item == null) return NotFound();

            _context.Suppliers.Remove(item);
            await _context.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}
