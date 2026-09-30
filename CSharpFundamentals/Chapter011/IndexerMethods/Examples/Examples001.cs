using IndexerMethods.Models;

namespace IndexerMethods.Examples;

internal static class Example001 {
    internal static void Run() {
        var people = new PersonCollectionIntegerIndexer();

        people[0] = new Person("Diego", "Alexandre", 38);
        people[1] = new Person("Amanda", "Perna", 33);
        people[2] = new Person("Eduarda", "Perna", 1);

        for (int i = 0; i < people.Count; i++) {
            Console.WriteLine(people[i]);
        }
    }
}