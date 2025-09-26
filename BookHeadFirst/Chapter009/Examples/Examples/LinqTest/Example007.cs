namespace Examples.LinqTest;

public static class Example007 {
    public static void Run() {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19];

        IEnumerable<int> evenNumbers =
            from number in numbers
            where number % 2 == 0
            select number;

        Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
    }
}