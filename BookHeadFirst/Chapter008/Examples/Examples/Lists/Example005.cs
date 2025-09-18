using Examples.Lists.Models;

namespace Examples.Lists;

public static class Example005 {
    public static void Run() {
        List<Duck> ducks = [
            new() { Kind = KindOfDuck.Mallard, Size = 17 },
            new() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new() { Kind = KindOfDuck.Loon, Size = 14 },
            new() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new() { Kind = KindOfDuck.Mallard, Size = 14 },
            new() { Kind = KindOfDuck.Loon, Size = 13 },
        ];

        IEnumerator<Duck> enumerator = ducks.GetEnumerator();

        while (enumerator.MoveNext()) {
            Duck current = enumerator.Current;
            Console.WriteLine(current);
        }

        enumerator.Dispose();
    }
}