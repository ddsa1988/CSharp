namespace ToDoList.Dto;

public record CreateToDoItemDto {
    public string? Title { get; init; }
    public string? Description { get; init; }
}