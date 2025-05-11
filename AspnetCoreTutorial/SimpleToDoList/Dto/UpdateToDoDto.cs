using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Dto;

public record UpdateToDoDto(
    [Required] string Description,
    bool IsCompleted);