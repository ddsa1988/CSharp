using ToDoList.Models;

namespace ToDoList;

public static class Program {
    public static void Main(string[] args) {
        var item = new ToDoItem("Shopping", "Description");

        Console.WriteLine(item);
    }
}