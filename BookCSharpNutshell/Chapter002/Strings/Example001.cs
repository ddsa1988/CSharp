namespace Chapter002.Strings;

public static class Example001 {
    public static void Run() {
        // The C# char type represents a Unicode character and occupies 2 bytes

        const char a = 'A';

        Console.WriteLine("{0} = {1}", nameof(a), a);
    }
}