namespace Chapter002.NumericTypes;

public static class Example002 {
    public static void Run() {
        // Numeric literals

        const int a = 127; // Decimal notation
        const long b = 0x7F; // Hexadecimal notation
        const int c = 0b1111111; // Binary notation
        const int d = 1_000_000; // Underscore notation [to make more readable]
        const double e = 1.5; // Decimal notation
        const double f = 1E06; // Exponential notation

        Console.WriteLine("{0} => {1}", nameof(a), a);
        Console.WriteLine("{0} => {1}", nameof(b), b);
        Console.WriteLine("{0} => {1}", nameof(c), c);
        Console.WriteLine("{0} => {1}", nameof(d), d);
        Console.WriteLine("{0} => {1}", nameof(e), e);
        Console.WriteLine("{0} => {1}", nameof(f), f);
    }
}