using Collections.Models;

namespace Collections.Examples;

internal static class UsingLists {
    public static void Run() {
        var people = new List<Person>() {
            new("Diego", "Alexander", 38),
            new("Amanda", "Perna", 32),
            new("Eduarda", "Perna", 1)
        };

        Console.WriteLine("Items in the list: " + people.Count);

        foreach (Person person in people) {
            Console.WriteLine(person);
        }

        people.Add(new Person("Alexander", "Perna", 40));

        Console.WriteLine("\nItems in the list: " + people.Count);
        foreach (Person person in people) {
            Console.WriteLine(person);
        }
    }
}