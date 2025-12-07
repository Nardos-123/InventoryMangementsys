using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // <-- 1. Needed for ToListAsync(), FindAsync(), etc.
using Datalayer.Data;              // <-- 2. Needed for InventoryDbContext
using Datalayer.Model;             // <-- 3. Needed for the Category model

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public UsersController(InventoryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, User updated)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            user.Username = updated.Username;
            user.Password = updated.Password;
            user.Role = updated.Role;

            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok("Deleted");
        }

        //Login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest(new { message = "Username and password are required" });

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == request.Username);

            if (user == null || user.Password != request.Password)
                return Unauthorized(new { message = "Invalid username or password" });

            // Success! You can later return a JWT token here
            return Ok(new
            {
                success = true,
                message = "Login successful",
                user = new
                {
                    user.UserId,
                    user.Username,
                    user.Role
                }
            });
        }
    }

    // DTO for login (add this inside the same file or in a DTO folder)
    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

}

