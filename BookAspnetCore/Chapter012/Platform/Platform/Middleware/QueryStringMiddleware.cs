namespace Platform.Middleware;

public class QueryStringMiddleware {
    private readonly RequestDelegate? _next;

    public QueryStringMiddleware() { }

    public QueryStringMiddleware(RequestDelegate nextDelegate) {
        _next = nextDelegate;
    }

    public async Task Invoke(HttpContext context) {
        if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true") {
            if (!context.Response.HasStarted) {
                context.Response.ContentType = "text/plain";
            }

            await context.Response.WriteAsync("Class-based Middleware\n");
        }

        if (_next == null) return;

        await _next(context);
    }
}