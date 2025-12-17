using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using Microsoft.AspNetCore.Identity;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string storeConnection = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Database", "SportsStore.db");
string identityConnection = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Database", "Identity.db");

//string? storeConnection = builder.Configuration.GetConnectionString("SportsStoreConnection");
//string? identityConnection = builder.Configuration.GetConnectionString("IdentityConnection");

builder.Services.AddDbContext<StoreDbContext>(options => { options.UseSqlite(storeConnection); });

builder.Services.AddDbContext<AppIdentityDbContext>(options => { options.UseSqlite(identityConnection); });
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppIdentityDbContext>();

builder.Services.AddScoped<IStoreRepository, EfStoreRepository>();
builder.Services.AddScoped<IOrderRepository, EfOrderRepository>();

builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddScoped(SessionCart.GetCart);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddServerSideBlazor();

WebApplication app = builder.Build();

app.UseStaticFiles();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

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
app.MapBlazorHub();
app.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");

SeedData.EnsurePopulated(app);

app.Run();