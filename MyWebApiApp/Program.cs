
using Microsoft.EntityFrameworkCore;
using WebApiApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Dodanie DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
