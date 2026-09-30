using IndexerMethods.Models;

namespace IndexerMethods.Examples;

internal static class Example002 {
    internal static void Run() {
        var people = new PersonCollectionStringIndexer();

        people["Diego"] = new Person("Diego", "Alexandre", 38);
        people["Amanda"] = new Person("Amanda", "Perna", 33);
        people["Eduarda"] = new Person("Eduarda", "Perna", 1);

        Console.WriteLine(people["Diego"]);
    }
}