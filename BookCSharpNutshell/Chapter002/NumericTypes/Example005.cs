namespace Chapter002.NumericTypes;

public static class Example005 {
    public static void UserMain() {
        // Numeric conversions

        const int a = 12345; // int is a 32-bit integer
        const long b = a; // Implicit conversion to 64-bit integral type
        const short c = (short)a; // Explicit conversion to 16-bit integral type
        const int d = 100000001;
        const float e = d; // Magnitude preserved, precision lost
        const int f = (int)e;

        Console.WriteLine("{0} = {1}", nameof(a), a);
        Console.WriteLine("{0} = {1}", nameof(b), b);
        Console.WriteLine("{0} = {1}", nameof(c), c);
        Console.WriteLine("{0} = {1}", nameof(d), d);
        Console.WriteLine("{0} = {1}", nameof(e), e);
        Console.WriteLine("{0} = {1}", nameof(f), f);
    }
}