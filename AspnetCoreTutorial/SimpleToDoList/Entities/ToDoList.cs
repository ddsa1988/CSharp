using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Entities;

public record ToDoList(
    [Required] [Range(1, int.MaxValue)] int Id,
    [Required] string Description,
    bool IsCompleted);