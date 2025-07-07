using System.Globalization;

namespace Chapter006.Strings;

public static class Example012 {
    public static void Run() {
        // String order comparison example

        string[] names = ["Tainara", "Diego", "Amanda", "Ivanice", "Rodrigo", "Mireli"];
        int length = names.Length;

        Console.WriteLine("Original => " + "[ " + string.Join(", ", names) + " ]");

        for (int i = 0; i < length - 1; i++) {
            for (int j = i + 1; j < length; j++) {
                if (string.CompareOrdinal(names[i], names[j]) <= 0) continue;

                (names[i], names[j]) = (names[j], names[i]);
            }
        }

        Console.WriteLine("Original => " + "[ " + string.Join(", ", names) + " ]");
    }
}