using Collections.Models;

namespace Collections.Examples;

internal static class UsingQueue {
    public static void Run() {
        var people = new Queue<Person>();

        people.Enqueue(new Person("Diego", "Alexander", 38));
        people.Enqueue(new Person("Amana", "Perna", 32));
        people.Enqueue(new Person("Eduarda", "Perna", 1));

        Console.WriteLine("First person: " + people.Peek()); // Object at the top of the stack

        Console.WriteLine();

        while (people.Count != 0) {
            Console.WriteLine("Person dequeued: " + people.Dequeue());
        }
    }
}