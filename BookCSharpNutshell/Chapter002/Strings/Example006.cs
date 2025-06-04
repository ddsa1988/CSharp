namespace Chapter002.Strings;

public static class Example006 {
    public static void Run() {
        // Wrapping a string in three or more quote characters (""") creates a raw string literal.
        // Raw string literals can contain almost any character sequence, without escaping or doubling up.

        const string raw1 = """<file path="c:\temp\test.txt"></file>""";
        const string raw2 = """"The """ sequence denotes raw string literals."""";
        const string raw3 = """
                            Line 1
                            Line 2
                            """;

        Console.WriteLine("{0} = {1}", nameof(raw1), raw1);
        Console.WriteLine("{0} = {1}", nameof(raw2), raw2);
        Console.WriteLine("{0} = {1}", nameof(raw3), raw3);
    }
}