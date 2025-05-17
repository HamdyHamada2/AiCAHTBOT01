//using ElectronicProductsAPI.Data;
//using Microsoft.EntityFrameworkCore;

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//options.UseSqlServer("Server=HAMDY\\SQLEXPRESS01;Database=ElectronicProductsDB;Trusted_Connection=True;TrustServerCertificate=True;"));

//var builder = WebApplication.CreateBuilder(args);

// لتفعيل CORS (لو هتستخدم Postman أو React قدام)
//builder.Services.AddCors();

//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

//app.UseHttpsRedirection();
//app.UseAuthorization();
//app.MapControllers();

//app.Run();

// ========== Program.cs ==========
using ElectronicProductsAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

