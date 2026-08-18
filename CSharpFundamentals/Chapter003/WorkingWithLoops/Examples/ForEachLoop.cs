namespace WorkingWithLoops.Examples;

internal static class ForEachLoop {
    internal static void Run() {
        string[] carTypes = ["Ford", "BMW", "Toyota", "Mercedes"];
        IEnumerable<int> numbers = Enumerable.Range(1, 10);

        foreach (string type in carTypes) {
            Console.Write(type + " ");
        }

        Console.WriteLine();

        foreach (int number in numbers) {
            Console.Write(number + " ");
        }
    }
}