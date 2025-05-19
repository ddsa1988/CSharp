using System.ComponentModel.DataAnnotations;

namespace SimpleToDoList.Dto;

public record ToDoDto(int Id, string Description, bool IsCompleted);