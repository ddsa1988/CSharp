namespace Chapter002.NullOperators;

public static class Example003 {
    public static void Run() {
        // The ?. operator is the null-conditional allows you to call methods and access members
        // just like the standard dot operator except that if the operand on the left is null,
        // the expression evaluates to null instead of throwing a NullReferenceException.

        string? myString = null;
        Console.WriteLine(myString?.Length ?? 0);

        string[]? words = null;
        string word = words?[1] ?? "Hello World";
        Console.WriteLine(word);
    }
}