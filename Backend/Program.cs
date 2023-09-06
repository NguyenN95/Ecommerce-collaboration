using Ecommerce.Seeding;
using Ecommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce;

public class Program
{
    private const string _devPolicy = "Development";

    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddCors(options =>
        {
            if (builder.Environment.IsDevelopment())
            {
                options.AddPolicy(_devPolicy, policy =>
                {
                    policy.WithOrigins("*")
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowAnyOrigin();
                });
            }
        });

        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseCors(_devPolicy);
        }

        app.UseAuthorization();


        app.MapControllers();

        using (var scope = app.Services.CreateScope())
        {
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            try
            {
                await context.Database.MigrateAsync();
                await DatabaseSeeding.SeedAsync(context);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occured during migrations");
            }
        }

        app.Run();
    }
}
