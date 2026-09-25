using Collections.Models;

namespace Collections.Examples;

internal static class UsingSortedSet {
    public static void Run() {
        var people = new SortedSet<Person>(new SortPeopleByAge()) {
            new("Diego", "Alexander", 38),
            new("Amana", "Perna", 32),
            new("Eduarda", "Perna", 1)
        };

        people.Add(new Person("Rodrigo", "Alexander", 35));

        foreach (Person person in people) {
            Console.WriteLine(person);
        }
    }
}