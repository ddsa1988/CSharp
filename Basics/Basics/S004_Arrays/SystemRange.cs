namespace Basics.S004_Arrays;

public static class SystemRange {
    public static void UserMain() {
        string[] names = ["Diego", "Amanda", "Amora", "Ameixa"];

        foreach (string name in names[0..2]) {
            Console.Write(name + " ");
        }

        Console.WriteLine();

        foreach (string name in names[..2]) {
            Console.Write(name + " ");
        }

        Console.WriteLine();

        foreach (string name in names[2..]) {
            Console.Write(name + " ");
        }

        Console.WriteLine();

        foreach (string name in names[0..^0]) {
            Console.Write(name + " ");
        }

        Console.WriteLine();

        Range range = 0..2;

        foreach (string name in names[range]) {
            Console.Write(name + " ");
        }
    }
}