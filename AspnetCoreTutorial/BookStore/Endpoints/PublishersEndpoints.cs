namespace BookStore.Endpoints;

public static class PublishersEndpoints {
    private const string GetPublisherEndpoint = "GetPublisher";

    public static RouteGroupBuilder MapPublishersEndpoints(this WebApplication app) {
        RouteGroupBuilder group = app.MapGroup("publishers").WithParameterValidation();

        return group;
    }
}