using Ecommerce.ShopProduct;
using Ecommerce.ShopProduct.ProductCategory;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Shared;

#nullable disable

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}