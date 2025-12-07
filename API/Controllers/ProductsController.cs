using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // <-- 1. Needed for ToListAsync(), FindAsync(), etc.
using Datalayer.Data;              // <-- 2. Needed for InventoryDbContext
using Datalayer.Model;             // <-- 3. Needed for the Category model
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
       
        private readonly InventoryDbContext _context;

        public ProductsController(InventoryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products
                .Include(c => c.Category)
                .Include(s => s.Supplier)
                .ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            product.CreatedAt = DateTime.Now;

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product updated)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            product.Name = updated.Name;
            product.CategoryId = updated.CategoryId;
            product.SupplierId = updated.SupplierId;
            product.Quantity = updated.Quantity;
            product.CostPrice = updated.CostPrice;
            product.SellingPrice = updated.SellingPrice;
            product.Description = updated.Description;

            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok("Deleted");
        }
    }
}
