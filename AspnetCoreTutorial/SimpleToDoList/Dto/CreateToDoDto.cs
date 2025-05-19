using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Dto;

public record CreateToDoDto(
    [Required] [StringLength(50)] string Description,
    bool IsCompleted);