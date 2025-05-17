//using Microsoft.EntityFrameworkCore;
//using AIChatBot.Model;

//namespace AIChatBot.Data
//{
//  public class ApplicationDbContext : DbContext
// {
//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

//    public DbSet<Product> Products { get; set; }
//  }
//}


// ========== Data/ApplicationDbContext.cs ==========
using Microsoft.EntityFrameworkCore;
using ElectronicProductsAPI.Models;

namespace ElectronicProductsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
