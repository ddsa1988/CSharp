using ToDoList.Dto;
using ToDoList.Models;

namespace ToDoList.ExtensionMethods;

internal static class CreateToDoItemExtension {
    internal static ToDoItem ToModel(this CreateToDoItemDto createToDoItemDto) {
        if (string.IsNullOrEmpty(createToDoItemDto.Title)) {
            throw new ArgumentException("Title cannot be null or whitespace.");
        }

        if (string.IsNullOrEmpty(createToDoItemDto.Description)) {
            throw new ArgumentException("Description cannot be null or whitespace.");
        }

        var toDoItem = new ToDoItem(createToDoItemDto.Title, createToDoItemDto.Description);

        return toDoItem;
    }
}