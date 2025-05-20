namespace BookStore.Dto.Book;

public record class BookSummaryDto(
    int Id,
    string Title,
    string Author,
    string Publisher,
    string Isbn,
    int Edition,
    float Price,
    DateOnly PublishDate);