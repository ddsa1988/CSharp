namespace LanguageIntegratedQuery.Examples;

internal static class LinqDeferredExecution {
    // LINQ query expressions not evaluated until you iterate over the resulting sequence.
    public static void Run() {
        int[] numbers = [10, 20, 30, 40, 1, 2, 3, 8];

        IEnumerable<int> subset =
            from number in numbers
            where number < 10
            select number;

        // LINQ statement evaluated here!
        foreach (int number in subset) {
            Console.WriteLine(number + " < 10");
        }

        Console.WriteLine();

        numbers[0] = 4;

        // LINQ statement evaluated here again!
        foreach (int number in subset) {
            Console.WriteLine(number + " < 10");
        }
    }
}