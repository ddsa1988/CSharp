namespace Chapter004.LambdaExpressions;

public static class Example003 {
    public static void Run() {
        // Lambda expressions can themselves update captured variables.

        int seed = 0;

        Func<int> natural = () => seed++;

        Console.WriteLine("{0} = {1}", nameof(natural), natural());
        Console.WriteLine("{0} = {1}", nameof(natural), natural());
        Console.WriteLine("{0} = {1}", nameof(natural), natural());
    }
}