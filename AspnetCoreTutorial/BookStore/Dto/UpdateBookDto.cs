using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto;

public record class UpdateBookDto(
    [Required] string Title,
    [Required] string Author,
    [Required] string Publisher,
    [Required] [Range(1, int.MaxValue)] int Edition,
    [Required] [Range(1, long.MaxValue)] long Isbn,
    [Required] DateOnly PublishDate);