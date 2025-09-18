using Examples.Lists.Models;

namespace Examples.Lists;

public static class Example006 {
    public static void Run() {
        List<Duck> ducks = [
            new() { Kind = KindOfDuck.Mallard, Size = 17 },
            new() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new() { Kind = KindOfDuck.Loon, Size = 14 },
            new() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new() { Kind = KindOfDuck.Mallard, Size = 14 },
            new() { Kind = KindOfDuck.Loon, Size = 13 },
        ];

        // Bird.FlyAway(ducks, "Curitiba"); // Error

        IEnumerable<Bird> upcastDucks = ducks;
        Bird.FlyAway(upcastDucks.ToList(), "Curitiba");
    }
}