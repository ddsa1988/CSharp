using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto.Author;

public record UpdateAuthorDto([Required] [StringLength(30)] string Name);