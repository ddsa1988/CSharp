using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Dto;

public record CreateToDoDto(
    [Required] string Description,
    bool IsCompleted);