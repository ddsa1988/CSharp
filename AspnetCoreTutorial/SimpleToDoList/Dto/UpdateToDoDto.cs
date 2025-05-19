using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Dto;

public record UpdateToDoDto(
    [Required] [StringLength(50)] string Description,
    bool IsCompleted);