using Ecommerce.ShopProduct;
using Ecommerce.ShopProduct.ProductCategory;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Shared;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public required DbSet<Product> Products { get; set; }
    public required DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var props = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));
                foreach (var prop in props)
                {
                    modelBuilder.Entity(entityType.Name).Property(prop.Name).HasConversion<double>();
                }
            }
        }
    }
}