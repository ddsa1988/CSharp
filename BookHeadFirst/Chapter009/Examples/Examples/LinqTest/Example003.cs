namespace Examples.LinqTest;

public static class Example003 {
    public static void Run() {
        int[] values = [0, 12, 44, 36, 92, 54, 13, 8];

        IEnumerable<int> result =
            from value in values
            where value < 37
            orderby -value
            select value;

        Console.WriteLine($"{nameof(result)} => {string.Join(", ", result)}");
    }
}