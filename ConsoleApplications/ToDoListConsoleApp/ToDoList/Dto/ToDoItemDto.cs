namespace ToDoList.Dto;

public record ToDoItemDto {
    public required string Title { get; init; }
    public required string Description { get; init; }
    public required string CreatedOn { get; init; }
    public required string ModifiedOn { get; init; }
    public bool IsDone { get; init; }
}