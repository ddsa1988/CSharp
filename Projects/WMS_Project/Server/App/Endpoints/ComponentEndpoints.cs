namespace App.Endpoints;

public static class ComponentEndpoints {
    public static RouteGroupBuilder MapComponentEndpoints(this WebApplication app) {
        const string getComponentEndpointName = "GetComponent";

        RouteGroupBuilder group = app.MapGroup("components").WithParameterValidation();

        return group;
    }
}