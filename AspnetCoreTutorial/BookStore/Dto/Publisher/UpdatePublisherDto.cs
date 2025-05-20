using System.ComponentModel.DataAnnotations;

namespace BookStore.Dto.Publisher;

public record UpdatePublisherDto([Required] [StringLength(30)] string Name);