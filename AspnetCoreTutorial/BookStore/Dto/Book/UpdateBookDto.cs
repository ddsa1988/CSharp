using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto.Book;

public record class UpdateBookDto(
    [Required] [StringLength(30)] string Title,
    [Required] [StringLength(30)] string Author,
    [Required] [StringLength(30)] string Publisher,
    [Required] [StringLength(20)] string Isbn,
    [Required] [Range(1, int.MaxValue)] int Edition,
    [Required] [Range(1, float.MaxValue)] float Price,
    [Required] DateOnly PublishDate);