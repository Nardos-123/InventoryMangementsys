using Microsoft.EntityFrameworkCore;
using Datalayer.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Read connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// 2. Register DbContext
builder.Services.AddDbContext<InventoryDbContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("API"))
);


// 3. Add controllers & swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 4. Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Inventory API v1");
        // optional: c.RoutePrefix = string.Empty; to serve swagger at root
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
