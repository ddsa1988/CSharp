using Platform.ExtensionMethod;

namespace Platform.Middleware;

public class Capital {
    private readonly RequestDelegate? _next;

    public Capital() { }

    public Capital(RequestDelegate nextDelegate) {
        _next = nextDelegate;
    }

    public async Task Invoke(HttpContext context) {
        string[] parts = context.Request.Path.ToString().Split('/', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length == 2 && parts[0] == "capital") {
            string country = parts[1];
            string? capital = null;

            switch (country) {
                case "uk":
                    capital = "London";
                    break;
                case "france":
                    capital = "Paris";
                    break;
                case "monaco":
                    context.Response.Redirect($"/population/{country}");
                    break;
            }

            if (capital != null) {
                await context.Response.WriteAsync($"{capital.Capitalize()} is the capital of {country.Capitalize()}\n");
            }
        }

        if (_next == null) return;

        await _next(context);
    }
}