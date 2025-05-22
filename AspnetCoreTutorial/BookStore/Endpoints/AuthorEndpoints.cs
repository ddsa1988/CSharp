namespace BookStore.Endpoints;

public static class AuthorEndpoints {
    private const string GetAuthorEndpoint = "GetAuthor";

    public static RouteGroupBuilder MapAuthorsEndpoints(this WebApplication app) {
        RouteGroupBuilder group = app.MapGroup("authors").WithParameterValidation();

        return group;
    }
}