using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // <-- 1. Needed for ToListAsync(), FindAsync(), etc.
using Datalayer.Data;              // <-- 2. Needed for InventoryDbContext
using Datalayer.Model;             // <-- 3. Needed for the Category model

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public CategoriesController(InventoryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Categories.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _context.Categories.FindAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category model)
        {
            _context.Categories.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Category updated)
        {
            var item = await _context.Categories.FindAsync(id);
            if (item == null) return NotFound();

            item.CategoryName = updated.CategoryName;

            await _context.SaveChangesAsync();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Categories.FindAsync(id);
            if (item == null) return NotFound();

            _context.Categories.Remove(item);
            await _context.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}
