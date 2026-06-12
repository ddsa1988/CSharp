namespace LinqQueries.Examples;

public static class LinqTest {
    public static void Run() {
        List<int> numbers = Enumerable.Range(1, 100).ToList();

        IEnumerable<int> firstFiveAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));

        Console.WriteLine(string.Join(", ", firstFiveAndLastFive));
    }
}