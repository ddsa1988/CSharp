using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto.Publisher;

public record CreatePublisherDto([Required] [StringLength(30)] string Name);