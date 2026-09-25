using Collections.Models;

namespace Collections.Examples;

internal static class UsingDictionary {
    public static void Run() {
        var people = new Dictionary<string, Person>() {
            { "First", new Person("Diego", "Alexander", 38) },
            { "Second", new Person("Amanda", "Perna", 32) },
            { "Third", new Person("Eduarda", "Perna", 1) },
        };

        foreach (KeyValuePair<string, Person> person in people) {
            Console.WriteLine($"{person.Key}: {person.Value}");
        }

        people["First"] = new Person("Alexander", "Perna", 38);
        people.Add("Fourth", new Person("Perna", "Alexander", 38));

        Console.WriteLine();

        foreach (KeyValuePair<string, Person> person in people) {
            Console.WriteLine($"{person.Key}: {person.Value}");
        }
    }
}