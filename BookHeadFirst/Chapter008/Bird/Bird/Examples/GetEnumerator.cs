using Bird.Models;

namespace Bird.Examples;

public static class GetEnumerator {
    public static void Run() {
        var ducks = new List<Duck>() {
            new() { Kind = KindOfDuck.Mallard, Size = 17 },
            new() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new() { Kind = KindOfDuck.Loon, Size = 14 },
            new() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new() { Kind = KindOfDuck.Mallard, Size = 14 },
            new() { Kind = KindOfDuck.Loon, Size = 13 },
        };

        IEnumerator<Duck> enumerator = ducks.GetEnumerator();

        while (enumerator.MoveNext()) {
            Duck duck = enumerator.Current;
            Console.WriteLine(duck);
        }

        if (enumerator is IDisposable disposable) {
            disposable.Dispose();
        }
    }
}