WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

// Custom middleware
app.Use(async (context, next) => {
    await next();
    await context.Response.WriteAsync($"\nStatus Code: {context.Response.StatusCode}\n");
});

app.Use(async (context, next) => {
    if (context.Request.Path == "/short") {
        await context.Response.WriteAsync("Request short circuited");
    } else {
        await next();
    }
});

app.Use(async (context, next) => {
    if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true") {
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync("Custom middleware \n");
    }

    await next();
});

app.UseMiddleware<Platform.Middlewares.QueryStringMiddleWare>();

app.MapGet("/", () => "Hello World!");

app.Run();