using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Dto;

public record ToDoDto(
    [Required] [Range(1, int.MaxValue)] int Id,
    [Required] string Description,
    bool IsCompleted);