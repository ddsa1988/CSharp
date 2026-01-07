using Platform.ExtensionMethod;

namespace Platform.Middleware;

public static class Population {
    public static async Task Endpoint(HttpContext context) {
        string? city = context.Request.RouteValues["city"] as string;

        int? population = (city?.ToLower() ?? "") switch {
            "london" => 8_136_000,
            "paris" => 2_141_000,
            "monaco" => 39_000,
            _ => null
        };

        if (population.HasValue) {
            await context.Response.WriteAsync($"City: {city?.Capitalize()}, Population: {population}\n");
        } else {
            context.Response.StatusCode = StatusCodes.Status404NotFound;
        }
    }
}