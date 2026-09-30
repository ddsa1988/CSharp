using IndexerMethods.Models;

namespace IndexerMethods.Examples;

internal static class Example003 {
    internal static void Run() {
        var people = new PersonCollectionIndexerOverload();

        people[0] = new Person("Diego", "Alexandre", 38);
        people[1] = new Person("Amanda", "Perna", 33);
        people[2] = new Person("Eduarda", "Perna", 1);


        Console.WriteLine(people["amanda"]);
    }
}