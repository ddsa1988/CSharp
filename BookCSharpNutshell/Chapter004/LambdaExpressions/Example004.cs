namespace Chapter004.LambdaExpressions;

public static class Example004 {
    public static void Run() {
        // Lambda expressions can themselves update captured variables.

        Func<int> natural = Natural();

        Console.WriteLine("{0} = {1}", nameof(natural), natural());
        Console.WriteLine("{0} = {1}", nameof(natural), natural());
        Console.WriteLine("{0} = {1}", nameof(natural), natural());
    }

    private static Func<int> Natural() {
        int seed = 0;

        return () => seed++; // Returns a closure
    }
}