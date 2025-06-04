namespace Chapter002.BooleanType;

public static class Example001 {
    public static void Run() {
        // For value types, equality compares the actual values of the variables

        const int a = 1;
        const int b = 2;
        const int c = 1;

        Console.WriteLine("{0} == {1} = {2}", a, b, a == b);
        Console.WriteLine("{0} == {1} = {2}", a, c, a == c);
    }
}