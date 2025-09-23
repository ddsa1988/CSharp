namespace Examples.LinqTest;

public static class Example001 {
    public static void Run() {
        var numbers = new List<int>();

        for (int i = 0; i < 20; i++) {
            numbers.Add(i);
        }

        IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));

        Console.WriteLine($"{nameof(numbers)} => {string.Join(", ", numbers)}");
        Console.WriteLine($"{nameof(firstAndLastFive)} => {string.Join(", ", firstAndLastFive)}");
    }
}