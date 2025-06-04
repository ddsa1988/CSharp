namespace Chapter002.NumericTypes;

public static class Example007 {
    public static void Run() {
        // Underflow and Overflow

        {
            Console.WriteLine("Underflow:\n");
            int a = int.MinValue;
            Console.WriteLine("{0} = {1}", nameof(a), a);
            Console.WriteLine("a--");
            a = unchecked(a - 1);
            Console.WriteLine("{0} = {1}", nameof(a), a);
        }

        Console.WriteLine();

        {
            Console.WriteLine("Overflow:\n");
            int a = int.MaxValue;
            Console.WriteLine("{0} = {1}", nameof(a), a);
            Console.WriteLine("a++");
            a = unchecked(a + 1);
            Console.WriteLine("{0} = {1}", nameof(a), a);
        }
    }
}