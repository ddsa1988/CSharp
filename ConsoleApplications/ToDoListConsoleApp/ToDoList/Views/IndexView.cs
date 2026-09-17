namespace ToDoList.Views;

internal static class IndexView {
    internal static void ShowMainMenu() {
        Console.Clear();
        Console.WriteLine("***** To Do List App *****\n");
        Console.WriteLine("1. Add a task");
        Console.WriteLine("2. Update a task");
        Console.WriteLine("3. Delete a task");
        Console.WriteLine("4. Show all tasks");
        Console.WriteLine("5. Exit");
    }
}