using Collections.Models;

namespace Collections.Examples;

internal static class UsingStack {
    public static void Run() {
        var people = new Stack<Person>();

        people.Push(new Person("Diego", "Alexander", 38));
        people.Push(new Person("Amana", "Perna", 32));
        people.Push(new Person("Eduarda", "Perna", 1));

        Console.WriteLine("First person: " + people.Peek()); // Object at the top of the stack

        Console.WriteLine();

        while (people.Count != 0) {
            Console.WriteLine("Person popped: " + people.Pop());
        }
    }
}