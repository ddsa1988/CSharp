namespace Chapter004.Patterns;

public static class Example004 {
    public static void Run() {
        // Tuple and Positional Patterns

        const int n1 = 2;
        const int n2 = 5;

        var p = (2, 5);

        Console.WriteLine("{0} is ({1}, {2}) => {3}", p, n1, n2, p is (n1, n2));

        Console.WriteLine(AverageCelsiusTemperature(Season.Winter, true));
    }

    private enum Season {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    private static int AverageCelsiusTemperature(Season season, bool daytime) {
        return (season, daytime) switch {
            (Season.Spring, true) => 20,
            (Season.Spring, false) => 16,
            (Season.Summer, true) => 27,
            (Season.Summer, false) => 22,
            (Season.Autumn, true) => 18,
            (Season.Autumn, false) => 12,
            (Season.Winter, true) => 10,
            (Season.Winter, false) => -2,
            _ => throw new Exception("Unexpected combination")
        };
    }
}