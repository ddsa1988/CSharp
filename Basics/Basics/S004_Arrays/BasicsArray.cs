namespace Basics.S004_Arrays;

public static class BasicsArray {
    public static void UserMain() {
        var random = new Random();
        const int size = 10;

        int[] numbers = new int[size];
        string[] names = ["Diego", "Amanda", "Amora", "Ameixa"];

        for (int i = 0; i < size; i++) numbers[i] = random.Next(size);

        PrintCollection(numbers);
        Console.WriteLine();
        PrintCollection(names);
    }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T value in collection) Console.Write(value + " ");
    }
}