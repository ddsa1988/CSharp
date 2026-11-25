namespace LanguageIntegratedQuery.Examples;

internal static class LinqImmediateExecution {
    // LINQ query expressions not evaluated until you iterate over the resulting sequence.
    public static void Run() {
        int[] numbers = [10, 20, 30, 40, 1, 2, 3, 8];

        // int[] subset =
        //     (from number in numbers
        //         where number < 10
        //         select number).ToArray();

        int[] subset = numbers.Where(number => number < 10).ToArray();


        foreach (int number in subset) {
            Console.WriteLine(number + " < 10");
        }
    }
}