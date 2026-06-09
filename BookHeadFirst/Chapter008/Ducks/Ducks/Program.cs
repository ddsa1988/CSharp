using Ducks.Models;

namespace Ducks;

public static class Program {
    public static void Main(string[] args) {
        var ducks = new List<Duck>() {
            new() { Kind = KindOfDuck.Mallard, Size = 17 },
            new() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new() { Kind = KindOfDuck.Loon, Size = 14 },
            new() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new() { Kind = KindOfDuck.Mallard, Size = 14 },
            new() { Kind = KindOfDuck.Loon, Size = 13 },
        };

        ducks.Sort();
        PrintDucks(ducks);
        Console.WriteLine();

        ducks.Sort(new DuckComparerBySizeDescending());
        PrintDucks(ducks);
        Console.WriteLine();

        ducks.Sort(new DuckComparerBySizeAscending());
        PrintDucks(ducks);
    }

    private static void PrintDucks(List<Duck> ducks) {
        foreach (Duck duck in ducks) {
            Console.WriteLine($"{duck.Size} inch {duck.Kind}");
        }
    }
}