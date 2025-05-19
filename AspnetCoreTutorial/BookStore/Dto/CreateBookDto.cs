using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto;

public record class CreateBookDto(
    [Required] [StringLength(30)] string Title,
    [Required] [StringLength(30)] string Author,
    [Required] [StringLength(30)] string Publisher,
    [Required] [Range(1, int.MaxValue)] int Edition,
    [Required] [Range(1, long.MaxValue)] long Isbn,
    [Required] [Range(1, float.MaxValue)] float Price,
    [Required] DateOnly PublishDate);