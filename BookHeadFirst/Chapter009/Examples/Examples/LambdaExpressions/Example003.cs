namespace Examples.LambdaExpressions;

public static class Example003 {
    public static void Run() {
        int[] numbers = [0, 12, 44, 36, 92, 54, 13, 8];

        // IEnumerable<int> result =
        //     from number in numbers
        //     where number < 37
        //     orderby number descending
        //     select number;

        IEnumerable<int> result = numbers.Where(number => number < 37).OrderByDescending(number => number);

        Console.WriteLine($"{nameof(result)} => {string.Join(", ", result)}");
    }
}