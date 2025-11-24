using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("SportsStoreConnection"));
});

builder.Services.AddScoped<IStoreRepository, EfStoreRepository>();

WebApplication app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();