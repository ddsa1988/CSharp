using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto.Book;

public record class CreateBookDto(
    [Required] [StringLength(30)] string Title,
    [Required] [Range(1, int.MaxValue)] int AuthorId,
    [Required] [Range(1, int.MaxValue)] int PublisherId,
    [Required] [StringLength(20)] string Isbn,
    [Required] [Range(1, int.MaxValue)] int Edition,
    [Required] [Range(1, float.MaxValue)] float Price,
    [Required] DateOnly PublishDate);