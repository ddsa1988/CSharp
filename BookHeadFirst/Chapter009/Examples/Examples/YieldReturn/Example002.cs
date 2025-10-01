using Examples.YieldReturn.Models;

namespace Examples.YieldReturn;

public static class Example002 {
    public static void Run() {
        var sports = new BetterSportSequence();

        foreach (Sport sport in sports) {
            Console.WriteLine(sport.ToString());
        }

        Console.WriteLine();
        Console.WriteLine(sports[5]);
    }
}