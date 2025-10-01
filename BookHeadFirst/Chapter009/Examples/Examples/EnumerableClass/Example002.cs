using Examples.EnumerableClass.Models;

namespace Examples.EnumerableClass;

public static class Example002 {
    public static void Run() {
        var sports = new ManualSportSequence();

        foreach (Sport sport in sports) {
            Console.WriteLine(sport.ToString());
        }

        Console.WriteLine();

        var sportEnumerator = new ManualSportEnumerator();

        while (sportEnumerator.MoveNext()) {
            Console.WriteLine(sportEnumerator.Current.ToString());
        }
    }
}