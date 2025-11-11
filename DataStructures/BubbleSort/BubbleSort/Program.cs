using BubbleSort.ExtensionMethods;

namespace BubbleSort;

public static class Program {
    public static void Main(string[] args) {
        int[] numbers = [0, 10, 5, 8, 6, 1, 3];
        string[] names = ["Rodrigo", "Diego", "Amanda"];

        Console.WriteLine(string.Join(", ", numbers));
        numbers.BubbleSort();
        Console.WriteLine(string.Join(", ", numbers));

        Console.WriteLine();

        Console.WriteLine(string.Join(", ", names));
        names.BubbleSort();
        Console.WriteLine(string.Join(", ", names));
    }
}