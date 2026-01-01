namespace Platform.Middleware;

public class Population {
    private readonly RequestDelegate? _next;

    public Population() { }

    public Population(RequestDelegate nextDelegate) {
        _next = nextDelegate;
    }

    public async Task Invoke(HttpContext context) {
        string[] parts = context.Request.Path.ToString().Split('/', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length == 2 && parts[0] == "population") {
            string city = parts[1];

            int? population = city.ToLower() switch {
                "london" => 8136000,
                "paris" => 2141000,
                "monaco" => 39000,
                _ => null
            };

            if (population.HasValue) {
                await context.Response.WriteAsync($"City: {city}, Population: {population}\n");
            }
        }

        if (_next == null) return;

        await _next(context);
    }
}