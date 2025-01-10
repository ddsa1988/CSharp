namespace Basics.S004_Arrays;

public static class SystemArray {
    public static void UserMain() {
        string[] names = ["Diego", "Rodrigo", "Amora", "Amanda"];

        Console.WriteLine($"Original array: [{string.Join(", ", names)}]");

        Array.Reverse(names);
        Console.WriteLine($"Reversed array: [{string.Join(", ", names)}]");

        Array.Sort(names);
        Console.WriteLine($"Sorted array: [{string.Join(", ", names)}]");
    }
}