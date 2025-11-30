using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string connectionString = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Database", "SportsStore.db");

//string? connectionString = builder.Configuration.GetConnectionString("SportsStoreConnection");

builder.Services.AddDbContext<StoreDbContext>(options => { options.UseSqlite(connectionString); });

builder.Services.AddScoped<IStoreRepository, EfStoreRepository>();

WebApplication app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("pagination", "Products/Page{productPage:int}", new { controller = "Home", action = "Index" });
app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();