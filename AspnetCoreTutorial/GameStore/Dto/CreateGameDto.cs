using System.ComponentModel.DataAnnotations;

namespace GameStore.Dto;

public record CreateGameDto(
    [Required] [StringLength(30)] string Name,
    [Required] [StringLength(20)] string Genre,
    [Required] [Range(1, 500)] float Price,
    DateOnly ReleaseDate);