namespace Basics.S004_Arrays;

public static class SystemArray {
    public static void UserMain() {
        string[] names = ["Diego", "Rodrigo", "Amora", "Amanda"];

        Console.WriteLine("Original array: ");
        PrintCollection(names);
        Console.WriteLine('\n');

        Array.Reverse(names);
        Console.WriteLine("Reversed array: ");
        PrintCollection(names);
        Console.WriteLine('\n');

        Array.Sort(names);
        Console.WriteLine("Sorted array: ");
        PrintCollection(names);
    }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T value in collection) Console.Write(value + " ");
    }
}