namespace Chapter002.NullOperators;

public static class Example001 {
    public static void Run() {
        // The ?? operator is the null-coalescing operator. It says, “If the operand to
        // the left is non-null, give it to me; otherwise, give me another value.”

        string? myString1 = null;
        string myString2 = myString1 ?? "Hello World";

        Console.WriteLine("{0} = {1}", nameof(myString2), myString2 ?? "null");
    }
}