using BookStore.Dto;

namespace BookStore.Endpoints;

public static class BooksEndpoints {
    private const string GetBookEndpoint = "GetBook";
    private static readonly List<BookDto> Books = Utils.Books.Create();

    public static WebApplication MapBooksEndpoints(this WebApplication app) {
        // Get /books
        app.MapGet("/books", () => Books);

        // Get /books/id
        app.MapGet("/books/{id:int}", (int id) => {
            BookDto? book = Books.Find(book => book.Id == id);

            return book == null ? Results.NotFound() : Results.Ok(book);
        }).WithName(GetBookEndpoint);

        return app;
    }
}