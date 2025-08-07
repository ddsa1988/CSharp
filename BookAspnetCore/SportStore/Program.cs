using SportStore.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Uses the MVC framework and the razor view engine

string? connectionString = builder.Configuration.GetConnectionString("SportStoreConnection");
builder.Services.AddSqlite<StoreDbContext>(connectionString); // Connect to Sqlite database

// Creates a service where each HTTP request gets its own repository object
builder.Services.AddScoped<IStoreRepository, EfStoreRepository>();

WebApplication app = builder.Build();

app.UseStaticFiles(); // Enable support for serving static content from the wwwroot folder
app.MapDefaultControllerRoute(); // Default endpoint routing

SeedData.EnsurePopulated(app); // Seed data to populate the database

app.Run();