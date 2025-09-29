namespace Examples.LambdaExpressions;

public static class Example002 {
    public static void Run() {
        int[] numbers = [1, 2, 3, 4];

        // IEnumerable<int> result = from number in numbers select number * 2;
        IEnumerable<int> result = numbers.Select(number => number * 2);

        Console.WriteLine($"{nameof(result)} => {string.Join(", ", result)}");
    }
}