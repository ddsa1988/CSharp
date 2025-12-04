using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string connectionString = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Database", "SportsStore.db");

//string? connectionString = builder.Configuration.GetConnectionString("SportsStoreConnection");

builder.Services.AddDbContext<StoreDbContext>(options => { options.UseSqlite(connectionString); });

builder.Services.AddScoped<IStoreRepository, EfStoreRepository>();

builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

WebApplication app = builder.Build();

app.UseStaticFiles();
app.UseSession();

app.MapControllerRoute("categoryPage", "{category}/Page{productPage:int}",
    new { controller = "Home", action = "Index" });

app.MapControllerRoute("page", "Page{productPage:int}",
    new { controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("category", "{category}",
    new { controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("pagination", "Products/Page{productPage:int}",
    new { controller = "Home", action = "Index", productPage = 1 });

app.MapDefaultControllerRoute();

app.MapRazorPages();

SeedData.EnsurePopulated(app);

app.Run();