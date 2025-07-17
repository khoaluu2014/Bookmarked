using BookMarked.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// Register services for API controllers
builder.Services.AddControllers();

// Register services for Swagger/OpenAPI documentation
builder.Services.AddEndpointsApiExplorer();

// 2. Build the application
var app = builder.Build();

// --- Configure the HTTP request pipeline (Middleware) ---

// Redirect HTTP requests to HTTPS for security
app.UseHttpsRedirection();

// Add authorization middleware
app.UseAuthorization();

// Map incoming requests to the correct API controllers
app.MapControllers();

// 3. Run the application
app.Run();
