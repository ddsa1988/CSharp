using BookStore.Dto.Book;

namespace BookStore.Utils;

public static class Books {
    public static List<BookSummaryDto> Create() {
        List<BookSummaryDto> books = [
            new BookSummaryDto(1, "Title 1", "Author 1", "Publisher 1", "123", 1, 19.9F,
                DateOnly.FromDateTime(new DateTime(2022, 10, 25))),
            new BookSummaryDto(2, "Title 2", "Author 2", "Publisher 2", "258", 3, 25.48F,
                DateOnly.FromDateTime(new DateTime(2019, 5, 13))),
            new BookSummaryDto(3, "Title 3", "Author 3", "Publisher 3", "689", 2, 7.8F,
                DateOnly.FromDateTime(new DateTime(2005, 8, 11)))
        ];

        return books;
    }
}