using Platform.Middleware;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("routing", async context => { await context.Response.WriteAsync("Request Was Routed"); });
app.MapGet("capital/uk", new Capital().Invoke);
app.MapGet("population/uk", new Population().Invoke);

app.Run();