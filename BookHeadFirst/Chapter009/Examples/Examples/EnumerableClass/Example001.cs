namespace Examples.EnumerableClass;

public static class Example001 {
    public static void Run() {
        IEnumerable<string> names = Enumerable.Repeat("Diego", 3);
        IEnumerable<int> numbers = Enumerable.Range(100, 5);
        IEnumerable<double> empty = Enumerable.Empty<double>();

        Console.WriteLine($"{nameof(names)} => {string.Join(", ", names)}");
        Console.WriteLine($"{nameof(numbers)} => {string.Join(", ", numbers)}");
        Console.WriteLine($"{nameof(empty)} => Count: {empty.Count()}");
    }
}