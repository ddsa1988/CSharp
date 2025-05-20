using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto.Author;

public record CreateAuthorDto([Required] [StringLength(30)] string Name);