using Examples.Lists.Models;

namespace Examples.Lists;

public static class Example003 {
    public static void Run() {
        List<Duck> ducks = [
            new() { Kind = KindOfDuck.Mallard, Size = 17 },
            new() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new() { Kind = KindOfDuck.Loon, Size = 14 },
            new() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new() { Kind = KindOfDuck.Mallard, Size = 14 },
            new() { Kind = KindOfDuck.Loon, Size = 13 },
        ];

        foreach (Duck duck in ducks) {
            Console.WriteLine(duck);
        }

        Console.WriteLine();

        var duckComparer = new DuckComparer();
        ducks.Sort(duckComparer.Compare);

        Console.WriteLine(string.Join("\n", ducks));
    }
}