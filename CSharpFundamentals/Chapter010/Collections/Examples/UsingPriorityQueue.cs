using Collections.Models;

namespace Collections.Examples;

internal static class UsingPriorityQueue {
    public static void Run() {
        var people = new PriorityQueue<Person, int>();

        people.Enqueue(new Person("Diego", "Alexander", 38), 2);
        people.Enqueue(new Person("Amana", "Perna", 32), 1);
        people.Enqueue(new Person("Eduarda", "Perna", 1), 3);

        Console.WriteLine("First person: " + people.Peek()); // Object at the top of the stack

        Console.WriteLine();

        while (people.Count != 0) {
            Console.WriteLine("Person dequeued: " + people.Dequeue());
        }
    }
}