using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Entities;

public class ToDo {
    public int Id { get; init; }
    [StringLength(50)] public required string Description { get; init; } = string.Empty;
    public bool IsCompleted { get; init; }
}