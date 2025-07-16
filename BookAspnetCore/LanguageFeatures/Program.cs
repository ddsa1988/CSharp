WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Enable mvc framework

WebApplication app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();

app.Run();