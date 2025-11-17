WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.Run();