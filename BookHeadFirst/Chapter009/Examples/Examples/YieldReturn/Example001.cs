namespace Examples.YieldReturn;

public static class Example001 {
    public static void Run() {
        foreach (string str in SimpleEnumerable()) {
            Console.WriteLine(str);
        }

        Console.WriteLine();

        IEnumerable<string> fruits = SimpleEnumerable();
        Console.WriteLine(string.Join(", ", fruits));
    }

    private static IEnumerable<string> SimpleEnumerable() {
        yield return "apples";
        yield return "oranges";
        yield return "bananas";
        yield return "grapes";
    }
}