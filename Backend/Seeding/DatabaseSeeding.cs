using Ecommerce.Shared;

namespace Ecommerce.Seeding;

public class DatabaseSeeding
{
    public static async Task SeedAsync(AppDbContext context)
    {
        await SeedProductsAsync(context);
    }
    private static async Task SeedProductsAsync(AppDbContext context)
    {
        // TODO: write your logic here
        await context.SaveChangesAsync();
    }
}