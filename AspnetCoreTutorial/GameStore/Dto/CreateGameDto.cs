using System.ComponentModel.DataAnnotations;

namespace GameStore.Dto;

public record CreateGameDto(
    [Required] [StringLength(30)] string Name,
    [Required] [Range(1, int.MaxValue)] int GenreId,
    [Required] [Range(1, 500)] float Price,
    DateOnly ReleaseDate);