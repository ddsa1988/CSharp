using Bird.Models;

namespace Bird.Examples;

public static class Covariance {
    // Covariance let you implicitly convert a subclass reference to its superclass
    // All collection implements IEnumerable
    public static void Run() {
        var ducks = new List<Duck>() {
            new() { Kind = KindOfDuck.Mallard, Size = 17 },
            new() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new() { Kind = KindOfDuck.Loon, Size = 14 },
            new() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new() { Kind = KindOfDuck.Mallard, Size = 14 },
            new() { Kind = KindOfDuck.Loon, Size = 13 },
        };

        IEnumerable<Aves> upcastDucks = ducks;
        Aves.FlyAway(upcastDucks.ToList(), "Curitiba");
    }
}