namespace App.Endpoints;

public static class ProjectEndpoints {
    public static RouteGroupBuilder MapProjectEndpoints(this WebApplication app) {
        const string getProjectEndpointName = "GetProject";

        RouteGroupBuilder group = app.MapGroup("projects").WithParameterValidation();

        return group;
    }
}