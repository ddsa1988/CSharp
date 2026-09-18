using ToDoList.Dto;

namespace ToDoList.Views;

internal static class AddTaskView {
    internal static void ShowHeader() {
        Console.Clear();
        Console.WriteLine("***** Add Task *****\n");
    }

    private static CreateToDoItemDto CreateToDoItem() {
        string? title;
        string? description;

        while (true) {
            Console.Write("Enter Task Title: ");
            title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title)) {
                Console.WriteLine("Invalid Task Title");
                continue;
            }

            break;
        }

        while (true) {
            Console.Write("Enter Task Description: ");
            description = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(description)) {
                Console.WriteLine("Invalid Task Title");
                continue;
            }

            break;
        }

        return new CreateToDoItemDto() { Title = title, Description = description };
    }
}