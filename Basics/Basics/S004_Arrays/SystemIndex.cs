namespace Basics.S004_Arrays;

public static class SystemIndex {
    public static void UserMain() {
        string[] names = ["Diego", "Amanda", "Amora", "Ameixa"];

        Console.WriteLine("names[names.length - 1] = " + names[names.Length - 1]);
        Console.WriteLine("names[^1] = " + names[^1]);
        Console.WriteLine();

        for (int i = 0; i < names.Length; i++) {
            Index idx = i;
            Console.Write(names[idx] + " ");
        }

        Console.WriteLine();

        for (int i = 1; i <= names.Length; i++) {
            Index idx = ^i;
            Console.Write(names[idx] + " ");
        }
    }
}