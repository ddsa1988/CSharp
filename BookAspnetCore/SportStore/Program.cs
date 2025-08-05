using SportStore.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("SportStoreConnection");
builder.Services.AddSqlite<StoreDbContext>(connectionString);

builder.Services.AddScoped<IStoreRepository, EfStoreRepository>();

WebApplication app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();