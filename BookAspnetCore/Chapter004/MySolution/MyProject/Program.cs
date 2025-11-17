WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/demo", () => {
    const string contentType = "text/html";
    string filePath = Path.Combine(app.Environment.WebRootPath, "demo.html");
    return Results.File(filePath, contentType);

    // string htmlContent = File.ReadAllText(filePath);
    // return Results.Content(htmlContent, contentType);
});

app.UseStaticFiles();

app.Run();