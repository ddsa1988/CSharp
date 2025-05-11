using BookStore.Dto;

namespace BookStore.Utils;

public static class Books {
    public static List<BookDto> Create() {
        List<BookDto> books = [
            new BookDto(1, "Title 1", "Author 1", "Publisher 1", 1, 123,
                DateOnly.FromDateTime(new DateTime(2022, 10, 25))),
            new BookDto(2, "Title 2", "Author 2", "Publisher 2", 1, 456,
                DateOnly.FromDateTime(new DateTime(2019, 5, 13))),
            new BookDto(3, "Title 3", "Author 3", "Publisher 3", 1, 789,
                DateOnly.FromDateTime(new DateTime(2005, 8, 11)))
        ];

        return books;
    }
}