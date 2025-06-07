using Microsoft.EntityFrameworkCore;
using ProductsShop.Models;
namespace ProductsShop.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Product> Products { get; set; }
}