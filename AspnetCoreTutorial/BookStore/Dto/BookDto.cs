namespace BookStore.Dto;

public record class BookDto(
    int Id,
    string Title,
    string Author,
    string Publisher,
    int Edition,
    long Isbn,
    float Price,
    DateOnly PublishDate);