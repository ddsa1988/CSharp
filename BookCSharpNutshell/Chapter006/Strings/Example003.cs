namespace Chapter006.Strings;

public static class Example003 {
    public static void Run() {
        // Null and empty strings

        const string empty = "";
        const string? nullString = null;

        Console.WriteLine(empty == "");
        Console.WriteLine(empty == string.Empty);
        Console.WriteLine(empty.Length == 0);

        Console.WriteLine();

        Console.WriteLine(nullString == null);
        Console.WriteLine(nullString == "");
    }
}