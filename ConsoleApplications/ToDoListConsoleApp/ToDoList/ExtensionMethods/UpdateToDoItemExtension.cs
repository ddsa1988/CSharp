using ToDoList.Dto;
using ToDoList.Models;

namespace ToDoList.ExtensionMethods;

internal static class UpdateToDoItemExtension {
    internal static void UpdateModel(this UpdateToDoItemDto updateToDoItemDto, ToDoItem item) {
        if (string.IsNullOrEmpty(updateToDoItemDto.Title)) {
            throw new ArgumentException("Title cannot be null or whitespace.");
        }

        if (string.IsNullOrEmpty(updateToDoItemDto.Description)) {
            throw new ArgumentException("Description cannot be null or whitespace.");
        }

        item.Title = updateToDoItemDto.Title;
        item.Description = updateToDoItemDto.Description;
        item.IsDone = updateToDoItemDto.IsDone;
    }
}