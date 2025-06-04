namespace Chapter002.NullOperators;

public static class Example002 {
    public static void Run() {
        // The ??= operator (introduced in C# 8) is the null-coalescing assignment operator.
        // It says, “If the operand to the left is null, assign the right operand to the left operand.”

        string? myString = null;
        Console.WriteLine("{0} = {1}", nameof(myString), myString ?? "null");

        myString ??= "Hello World";
        Console.WriteLine("{0} = {1}", nameof(myString), myString ?? "null");
    }
}