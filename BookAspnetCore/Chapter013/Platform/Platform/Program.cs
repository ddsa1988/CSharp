using Platform.Middleware;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("routing", async context => { await context.Response.WriteAsync("Request Was Routed"); });

app.MapGet("capital/{country}", Capital.Endpoint);

app.MapGet("population/{city}", Population.Endpoint);

app.MapGet("{first}/{second}/{third}", async context => {
    await context.Response.WriteAsync("Request Was Routed\n");
    foreach (KeyValuePair<string, object?> kvp in context.Request.RouteValues) {
        await context.Response.WriteAsync($"{kvp.Key}: {kvp.Value}\n");
    }
});

app.Run();