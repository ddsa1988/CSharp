namespace Chapter002.NumericTypes;

public static class Example003 {
    public static void UserMain() {
        // Numeric literal type inference

        Console.WriteLine(1.GetType());
        Console.WriteLine(1.0.GetType());
        Console.WriteLine(1E06.GetType());
        Console.WriteLine(0xF0000000.GetType());
        Console.WriteLine(0x100000000.GetType());
    }
}

