namespace App.Endpoints;

public static class LocationEndpoints {
    public static RouteGroupBuilder MapLocationEndpoints(this WebApplication app) {
        const string getLocationEndpointName = "GetLocation";

        RouteGroupBuilder group = app.MapGroup("locations").WithParameterValidation();

        return group;
    }
}