namespace ToDoList.Dto;

public record UpdateToDoItemDto {
    public string? Title { get; init; }
    public string? Description { get; init; }
    public bool IsDone { get; init; }
}